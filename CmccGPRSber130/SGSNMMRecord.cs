
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
    [ASN1Sequence ( Name = "SGSNMMRecord", IsSet = true  )]
    public class SGSNMMRecord : IASN1PreparedElement {
                    
	private CallEventRecordType recordType_ ;
	
        [ASN1Element ( Name = "recordType", IsOptional =  false , HasTag =  true, Tag = 0 , HasDefaultValue =  false )  ]
    
        public CallEventRecordType RecordType
        {
            get { return recordType_; }
            set { recordType_ = value;  }
        }
        
                
          
	private IMSI servedIMSI_ ;
	
        [ASN1Element ( Name = "servedIMSI", IsOptional =  false , HasTag =  true, Tag = 1 , HasDefaultValue =  false )  ]
    
        public IMSI ServedIMSI
        {
            get { return servedIMSI_; }
            set { servedIMSI_ = value;  }
        }
        
                
          
	private IMEI servedIMEI_ ;
	
        private bool  servedIMEI_present = false ;
	
        [ASN1Element ( Name = "servedIMEI", IsOptional =  true , HasTag =  true, Tag = 2 , HasDefaultValue =  false )  ]
    
        public IMEI ServedIMEI
        {
            get { return servedIMEI_; }
            set { servedIMEI_ = value; servedIMEI_present = true;  }
        }
        
                
          
	private GSNAddress sgsnAddress_ ;
	
        [ASN1Element ( Name = "sgsnAddress", IsOptional =  false , HasTag =  true, Tag = 3, IsImplicitTag = false  , HasDefaultValue =  false )  ]
    
        public GSNAddress SgsnAddress
        {
            get { return sgsnAddress_; }
            set { sgsnAddress_ = value;  }
        }
        
                
          
	private MSNetworkCapability msNetworkCapability_ ;
	
        private bool  msNetworkCapability_present = false ;
	
        [ASN1Element ( Name = "msNetworkCapability", IsOptional =  true , HasTag =  true, Tag = 4 , HasDefaultValue =  false )  ]
    
        public MSNetworkCapability MsNetworkCapability
        {
            get { return msNetworkCapability_; }
            set { msNetworkCapability_ = value; msNetworkCapability_present = true;  }
        }
        
                
          
	private RoutingAreaCode routingArea_ ;
	
        private bool  routingArea_present = false ;
	
        [ASN1Element ( Name = "routingArea", IsOptional =  true , HasTag =  true, Tag = 5 , HasDefaultValue =  false )  ]
    
        public RoutingAreaCode RoutingArea
        {
            get { return routingArea_; }
            set { routingArea_ = value; routingArea_present = true;  }
        }
        
                
          
	private LocationAreaCode locationAreaCode_ ;
	
        private bool  locationAreaCode_present = false ;
	
        [ASN1Element ( Name = "locationAreaCode", IsOptional =  true , HasTag =  true, Tag = 6 , HasDefaultValue =  false )  ]
    
        public LocationAreaCode LocationAreaCode
        {
            get { return locationAreaCode_; }
            set { locationAreaCode_ = value; locationAreaCode_present = true;  }
        }
        
                
          
	private CellId cellIdentity_ ;
	
        private bool  cellIdentity_present = false ;
	
        [ASN1Element ( Name = "cellIdentity", IsOptional =  true , HasTag =  true, Tag = 7 , HasDefaultValue =  false )  ]
    
        public CellId CellIdentity
        {
            get { return cellIdentity_; }
            set { cellIdentity_ = value; cellIdentity_present = true;  }
        }
        
                
          
	private System.Collections.Generic.ICollection<ChangeLocation> changeLocation_ ;
	
        private bool  changeLocation_present = false ;
	
[ASN1SequenceOf( Name = "", IsSetOf = false  )]

    
        [ASN1Element ( Name = "changeLocation", IsOptional =  true , HasTag =  true, Tag = 8 , HasDefaultValue =  false )  ]
    
        public System.Collections.Generic.ICollection<ChangeLocation> ChangeLocation
        {
            get { return changeLocation_; }
            set { changeLocation_ = value; changeLocation_present = true;  }
        }
        
                
          
	private TimeStamp recordOpeningTime_ ;
	
        [ASN1Element ( Name = "recordOpeningTime", IsOptional =  false , HasTag =  true, Tag = 9 , HasDefaultValue =  false )  ]
    
        public TimeStamp RecordOpeningTime
        {
            get { return recordOpeningTime_; }
            set { recordOpeningTime_ = value;  }
        }
        
                
          
	private CallDuration duration_ ;
	
        private bool  duration_present = false ;
	
        [ASN1Element ( Name = "duration", IsOptional =  true , HasTag =  true, Tag = 10 , HasDefaultValue =  false )  ]
    
        public CallDuration Duration
        {
            get { return duration_; }
            set { duration_ = value; duration_present = true;  }
        }
        
                
          
	private SGSNChange sgsnChange_ ;
	
        private bool  sgsnChange_present = false ;
	
        [ASN1Element ( Name = "sgsnChange", IsOptional =  true , HasTag =  true, Tag = 11 , HasDefaultValue =  false )  ]
    
        public SGSNChange SgsnChange
        {
            get { return sgsnChange_; }
            set { sgsnChange_ = value; sgsnChange_present = true;  }
        }
        
                
          
	private CauseForRecClosing causeForRecClosing_ ;
	
        [ASN1Element ( Name = "causeForRecClosing", IsOptional =  false , HasTag =  true, Tag = 12 , HasDefaultValue =  false )  ]
    
        public CauseForRecClosing CauseForRecClosing
        {
            get { return causeForRecClosing_; }
            set { causeForRecClosing_ = value;  }
        }
        
                
          
	private Diagnostics diagnostics_ ;
	
        private bool  diagnostics_present = false ;
	
        [ASN1Element ( Name = "diagnostics", IsOptional =  true , HasTag =  true, Tag = 13 , HasDefaultValue =  false )  ]
    
        public Diagnostics Diagnostics
        {
            get { return diagnostics_; }
            set { diagnostics_ = value; diagnostics_present = true;  }
        }
        
                
          
	private long recordSequenceNumber_ ;
	
        private bool  recordSequenceNumber_present = false ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "recordSequenceNumber", IsOptional =  true , HasTag =  true, Tag = 14 , HasDefaultValue =  false )  ]
    
        public long RecordSequenceNumber
        {
            get { return recordSequenceNumber_; }
            set { recordSequenceNumber_ = value; recordSequenceNumber_present = true;  }
        }
        
                
          
	private NodeID nodeID_ ;
	
        private bool  nodeID_present = false ;
	
        [ASN1Element ( Name = "nodeID", IsOptional =  true , HasTag =  true, Tag = 15 , HasDefaultValue =  false )  ]
    
        public NodeID NodeID
        {
            get { return nodeID_; }
            set { nodeID_ = value; nodeID_present = true;  }
        }
        
                
          
	private ManagementExtensions recordExtensions_ ;
	
        private bool  recordExtensions_present = false ;
	
        [ASN1Element ( Name = "recordExtensions", IsOptional =  true , HasTag =  true, Tag = 16 , HasDefaultValue =  false )  ]
    
        public ManagementExtensions RecordExtensions
        {
            get { return recordExtensions_; }
            set { recordExtensions_ = value; recordExtensions_present = true;  }
        }
        
                
          
	private LocalSequenceNumber localSequenceNumber_ ;
	
        private bool  localSequenceNumber_present = false ;
	
        [ASN1Element ( Name = "localSequenceNumber", IsOptional =  true , HasTag =  true, Tag = 17 , HasDefaultValue =  false )  ]
    
        public LocalSequenceNumber LocalSequenceNumber
        {
            get { return localSequenceNumber_; }
            set { localSequenceNumber_ = value; localSequenceNumber_present = true;  }
        }
        
                
  
        public bool isServedIMEIPresent () {
            return this.servedIMEI_present == true;
        }
        
        public bool isMsNetworkCapabilityPresent () {
            return this.msNetworkCapability_present == true;
        }
        
        public bool isRoutingAreaPresent () {
            return this.routingArea_present == true;
        }
        
        public bool isLocationAreaCodePresent () {
            return this.locationAreaCode_present == true;
        }
        
        public bool isCellIdentityPresent () {
            return this.cellIdentity_present == true;
        }
        
        public bool isChangeLocationPresent () {
            return this.changeLocation_present == true;
        }
        
        public bool isDurationPresent () {
            return this.duration_present == true;
        }
        
        public bool isSgsnChangePresent () {
            return this.sgsnChange_present == true;
        }
        
        public bool isDiagnosticsPresent () {
            return this.diagnostics_present == true;
        }
        
        public bool isRecordSequenceNumberPresent () {
            return this.recordSequenceNumber_present == true;
        }
        
        public bool isNodeIDPresent () {
            return this.nodeID_present == true;
        }
        
        public bool isRecordExtensionsPresent () {
            return this.recordExtensions_present == true;
        }
        
        public bool isLocalSequenceNumberPresent () {
            return this.localSequenceNumber_present == true;
        }
        

            public void initWithDefaults() {
            	
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(SGSNMMRecord));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
