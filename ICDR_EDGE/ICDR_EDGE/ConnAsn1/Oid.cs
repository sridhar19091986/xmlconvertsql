
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace Asn1Processor
{
    /// <summary>
    /// Summary description for OID.
    /// This class is used to encode and decode OID strings.
    /// </summary>
    public class Oid
    {
        /// <summary>
        /// Retrieve OID name by OID string.
        /// </summary>
        /// <param name="inOidStr">source OID string.</param>
        /// <returns>OID name.</returns>
        public string GetOidName(string inOidStr)
        {
            if (oidDictionary == null) //Initialize oidDictionary:
            {
                oidDictionary = new StringDictionary();
                string path = Application.ExecutablePath;
                string oidFile = System.IO.Path.GetDirectoryName(path) + "\\OID.txt";
                string oidBackupFile = System.IO.Path.GetDirectoryName(path) + "\\OID.Backup.txt";
                string oidStr = "";
                string oidDesc = "";
                bool loadOidError = false;
                int dbCounter = 0;
                try
                {
                    using (StreamReader sr = new StreamReader(oidFile))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] strs = line.Split(',');
                            if (strs.Length < 2) continue;
                            oidStr = strs[0].Trim();
                            oidDesc = strs[1].Trim();
                            try
                            {
                                oidDictionary.Add(oidStr, oidDesc);
                            }
                            catch(Exception ex)
                            {
                                loadOidError = true;
                                string msg = ex.Message;
                                dbCounter ++;
                            }
                        }
                    }
                    if (loadOidError)
                    {
                        using (StreamWriter sw = new StreamWriter(oidBackupFile))
                        {

                            using (StreamReader sr = new StreamReader(oidFile))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    sw.Write(line+"\r\n");
                                }
                            }
                        }

                        System.Collections.SortedList sList = new System.Collections.SortedList();
                        using (StreamWriter sw = new StreamWriter(oidFile))
                        {
                            string val = "";
                            foreach ( System.Collections.DictionaryEntry de in oidDictionary )
                            {
                                if (!sList.ContainsKey(de.Key))
                                    sList.Add(de.Key, de.Value);
                            }
                            for(int i=0; i<sList.Count; i++)
                            {
                                val = String.Format("{0}, {1}\r\n", sList.GetKey(i), sList.GetByIndex(i));
                                sw.Write(val);
                            }
                        }
                        MessageBox.Show(String.Format("Duplicated OIDs were found in the OID table: {0}.\r\n" +
                            "The duplicate has been removed; the table is sorted.\r\n" +
                            "The original OID file is copied as: {1}\r\n", oidFile, oidBackupFile));
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed to read OID values from file." + ex.Message);
                }
            }
            return oidDictionary[inOidStr];
        }

        /// <summary>
        /// Encode OID string to byte array.
        /// </summary>
        /// <param name="oidStr">source string.</param>
        /// <returns>encoded array.</returns>
        public byte[] Encode(string oidStr)
        {
            MemoryStream ms = new MemoryStream();
            Encode(ms, oidStr);
            //ms.Position = 0;
            byte[] retval = new byte[ms.Length];
            ms.Read(retval, 0, retval.Length);
            ms.Close();
            return retval;
        }

        /// <summary>
        /// Decode OID byte array to OID string.
        /// </summary>
        /// <param name="data">source byte array.</param>
        /// <returns>result OID string.</returns>
        public string Decode(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            //ms.Position = 0;
            string retval = Decode(ms);
            ms.Close();
            return retval;
        }
        
        /// <summary>
        /// Encode OID string and put result into <see cref="Stream"/>
        /// </summary>
        /// <param name="bt">output stream.</param>
        /// <param name="oidStr">source OID string.</param>
        public virtual void Encode(Stream bt, string oidStr) //TODO
        {
            string[] oidList = oidStr.Split('.');
            if (oidList.Length < 2) throw new Exception("Invalid OID string.");
            ulong[] values = new ulong[oidList.Length];
            for (int i = 0; i<oidList.Length; i++)
            {
                values[i] = Convert.ToUInt64(oidList[i]);
            }
            bt.WriteByte((byte)(values[0] * 40 + values[1]));
            for (int i=2; i<values.Length; i++)
                EncodeValue(bt, values[i]);
        }

        /// <summary>
        /// Decode OID <see cref="Stream"/> and return OID string.
        /// </summary>
        /// <param name="bt">source stream.</param>
        /// <returns>result OID string.</returns>
        public virtual string Decode(Stream bt)
        {
            string retval = "";
            byte b;
            ulong v = 0;
            b = (byte) bt.ReadByte();
            retval += Convert.ToString(b/40);
            retval += "." + Convert.ToString(b%40);
            while (bt.Position < bt.Length)
            {
                try
                {
                    DecodeValue(bt, ref v);
                    retval += "." + v.ToString();
                }
                catch(Exception e)
                {
                    throw new Exception("Failed to decode OID value: " + e.Message);
                }
            }
            return retval;
        }

        /// <summary>
        /// OID dictionary.
        /// </summary>
        private static StringDictionary oidDictionary = null;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Oid() 
        {
        }

        /// <summary>
        /// Encode single OID value.
        /// </summary>
        /// <param name="bt">output stream.</param>
        /// <param name="v">source value.</param>
        protected void EncodeValue(Stream bt, ulong v)
        {
            for (int i=(Asn1Util.BitPrecision(v)-1)/7; i > 0; i--)
            {
                bt.WriteByte((byte)(0x80 | ((v >> (i*7)) & 0x7f)));
            }
            bt.WriteByte((byte)(v & 0x7f));
        }

        /// <summary>
        /// Decode single OID value.
        /// </summary>
        /// <param name="bt">source stream.</param>
        /// <param name="v">output value</param>
        /// <returns>OID value bytes.</returns>
        protected int DecodeValue(Stream bt, ref ulong v)
        {
            byte b;
            int i=0;
            v = 0;
            while (true)
            {
                b = (byte) bt.ReadByte();
                i++;
                v <<= 7;
                v += (ulong) (b & 0x7f);
                if ((b & 0x80) == 0)
                    return i;
            }
        }

    }
}

