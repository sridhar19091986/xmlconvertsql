
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

namespace CmccGPRSber130.asn {


    [ASN1PreparedElement]
    [ASN1BoxedType ( Name = "AccessPointNameOI") ]
    public class AccessPointNameOI: IASN1PreparedElement {
    
            private byte[] val = null;

            [ASN1OctetString( Name = "AccessPointNameOI") ]            
            [ASN1ValueRangeConstraint ( 
		
		Min = 1L, 
		
		Max = 37L 
		
		) ]
	    
            public byte[] Value
            {
                get { return val; }
                set { val = value; }
            }            
            
            public AccessPointNameOI() {
            }

            public AccessPointNameOI(byte[] value) {
                this.Value = value;
            }            
            
            public AccessPointNameOI(BitString value) {
                this.Value = value.Value;
            }                        

            public void initWithDefaults()
	    {
	    }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(AccessPointNameOI));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}
