
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
    [ASN1BoxedType ( Name = "DynamicAddressFlag") ]
    public class DynamicAddressFlag: IASN1PreparedElement {
    
            private bool? val = null;

            [ASN1Boolean ( Name = "DynamicAddressFlag") ]            
            
            public bool? Value
            {
                get { return val; }
                set { val = value; }
            }            
            
            public DynamicAddressFlag() {
            }

            public DynamicAddressFlag(bool value) {
                this.Value = value;
            }            

            public void initWithDefaults()
	    {
	    }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(DynamicAddressFlag));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
