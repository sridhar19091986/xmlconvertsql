
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace GPRSber {


    [ASN1PreparedElement]
    [ASN1BoxedType ( Name = "TimeStamp") ]
    public class TimeStamp: IASN1PreparedElement {
    
            private byte[] val = null;

            [ASN1OctetString( Name = "TimeStamp") ]            
            
            [ASN1SizeConstraint ( Max = 9L )]
        
            public byte[] Value
            {
                get { return val; }
                set { val = value; }
            }            
            
            public TimeStamp() {
            }

            public TimeStamp(byte[] value) {
                this.Value = value;
            }            
            
            public TimeStamp(BitString value) {
                this.Value = value.Value;
            }                        

            public void initWithDefaults()
	    {
	    }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(TimeStamp));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}
