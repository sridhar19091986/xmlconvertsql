
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
    [ASN1BoxedType ( Name = "RoutingAreaCode") ]
    public class RoutingAreaCode: IASN1PreparedElement {
    
            private byte[] val = null;

            [ASN1OctetString( Name = "RoutingAreaCode") ]            
            
            [ASN1SizeConstraint ( Max = 1L )]
        
            public byte[] Value
            {
                get { return val; }
                set { val = value; }
            }            
            
            public RoutingAreaCode() {
            }

            public RoutingAreaCode(byte[] value) {
                this.Value = value;
            }            
            
            public RoutingAreaCode(BitString value) {
                this.Value = value.Value;
            }                        

            public void initWithDefaults()
	    {
	    }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(RoutingAreaCode));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}
