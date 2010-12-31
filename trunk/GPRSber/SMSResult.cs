
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
    [ASN1BoxedType ( Name = "SMSResult") ]
    public class SMSResult: IASN1PreparedElement {
            
           
        private Diagnostics  val;

        
        [ASN1Element ( Name = "SMSResult", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public Diagnostics Value
        {
                get { return val; }        
                    
                set { val = value; }
                        
        }            

                    
        
        public SMSResult ()
        {
        }

            public void initWithDefaults()
	    {
	    }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(SMSResult));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

        
    }
            
}