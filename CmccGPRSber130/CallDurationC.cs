
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
    [ASN1Sequence ( Name = "CallDurationC", IsSet = false  )]
    public class CallDurationC : IASN1PreparedElement {
                    
	private long peak_ ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "peak", IsOptional =  false , HasTag =  true, Tag = 0 , HasDefaultValue =  false )  ]
    
        public long Peak
        {
            get { return peak_; }
            set { peak_ = value;  }
        }
        
                
          
	private long offPeak_ ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "offPeak", IsOptional =  false , HasTag =  true, Tag = 1 , HasDefaultValue =  false )  ]
    
        public long OffPeak
        {
            get { return offPeak_; }
            set { offPeak_ = value;  }
        }
        
                
  

            public void initWithDefaults() {
            	
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(CallDurationC));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
