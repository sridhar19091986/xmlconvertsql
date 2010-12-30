
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
    [ASN1BoxedType ( Name = "RecordNumber" )]
    public class RecordNumber: IASN1PreparedElement {
    
            private long val;
            
            [ASN1Integer( Name = "RecordNumber" )]
            
            public long Value
            {
                get { return val; }
                set { val = value; }
            }
            
            public RecordNumber() {
            }

            public RecordNumber(long value) {
                this.Value = value;
            }            

            public void initWithDefaults()
	    {
	    }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(RecordNumber));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}
