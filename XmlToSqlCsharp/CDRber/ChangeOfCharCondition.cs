
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
    [ASN1Sequence ( Name = "ChangeOfCharCondition", IsSet = false  )]
    public class ChangeOfCharCondition : IASN1PreparedElement {
                    
	private QoSInformation qosRequested_ ;
	
        private bool  qosRequested_present = false ;
	
        [ASN1Element ( Name = "qosRequested", IsOptional =  true , HasTag =  true, Tag = 1 , HasDefaultValue =  false )  ]
    
        public QoSInformation QosRequested
        {
            get { return qosRequested_; }
            set { qosRequested_ = value; qosRequested_present = true;  }
        }
        
                
          
	private QoSInformation qosNegotiated_ ;
	
        private bool  qosNegotiated_present = false ;
	
        [ASN1Element ( Name = "qosNegotiated", IsOptional =  true , HasTag =  true, Tag = 2 , HasDefaultValue =  false )  ]
    
        public QoSInformation QosNegotiated
        {
            get { return qosNegotiated_; }
            set { qosNegotiated_ = value; qosNegotiated_present = true;  }
        }
        
                
          
	private DataVolumeGPRS dataVolumeGPRSUplink_ ;
	
        [ASN1Element ( Name = "dataVolumeGPRSUplink", IsOptional =  false , HasTag =  true, Tag = 3 , HasDefaultValue =  false )  ]
    
        public DataVolumeGPRS DataVolumeGPRSUplink
        {
            get { return dataVolumeGPRSUplink_; }
            set { dataVolumeGPRSUplink_ = value;  }
        }
        
                
          
	private DataVolumeGPRS dataVolumeGPRSDownlink_ ;
	
        [ASN1Element ( Name = "dataVolumeGPRSDownlink", IsOptional =  false , HasTag =  true, Tag = 4 , HasDefaultValue =  false )  ]
    
        public DataVolumeGPRS DataVolumeGPRSDownlink
        {
            get { return dataVolumeGPRSDownlink_; }
            set { dataVolumeGPRSDownlink_ = value;  }
        }
        
                
          
	private ChangeCondition changeCondition_ ;
	
        [ASN1Element ( Name = "changeCondition", IsOptional =  false , HasTag =  true, Tag = 5 , HasDefaultValue =  false )  ]
    
        public ChangeCondition ChangeCondition
        {
            get { return changeCondition_; }
            set { changeCondition_ = value;  }
        }
        
                
          
	private TimeStamp changeTime_ ;
	
        [ASN1Element ( Name = "changeTime", IsOptional =  false , HasTag =  true, Tag = 6 , HasDefaultValue =  false )  ]
    
        public TimeStamp ChangeTime
        {
            get { return changeTime_; }
            set { changeTime_ = value;  }
        }
        
                
  
        public bool isQosRequestedPresent () {
            return this.qosRequested_present == true;
        }
        
        public bool isQosNegotiatedPresent () {
            return this.qosNegotiated_present == true;
        }
        

            public void initWithDefaults() {
            	
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(ChangeOfCharCondition));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
