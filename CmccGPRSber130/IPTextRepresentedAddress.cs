
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
    [ASN1Choice ( Name = "IPTextRepresentedAddress") ]
    public class IPTextRepresentedAddress : IASN1PreparedElement {
                    
        
	private byte[] iPTextV4Address_ ;
        private bool  iPTextV4Address_selected = false ;
        
        
        
        [ASN1Element ( Name = "iPTextV4Address", IsOptional =  false , HasTag =  true, Tag = 2 , HasDefaultValue =  false )  ]
    [ASN1OctetString( Name = "" )]
    [ASN1ValueRangeConstraint ( 
		
		Min = 7L, 
		
		Max = 15L 
		
		) ]
	    
        public byte[] IPTextV4Address
        {
            get { return iPTextV4Address_; }
            set { selectIPTextV4Address(value); }
        }
        
                
          
        
	private byte[] iPTextV6Address_ ;
        private bool  iPTextV6Address_selected = false ;
        
        
        
        [ASN1Element ( Name = "iPTextV6Address", IsOptional =  false , HasTag =  true, Tag = 3 , HasDefaultValue =  false )  ]
    [ASN1OctetString( Name = "" )]
    [ASN1ValueRangeConstraint ( 
		
		Min = 15L, 
		
		Max = 45L 
		
		) ]
	    
        public byte[] IPTextV6Address
        {
            get { return iPTextV6Address_; }
            set { selectIPTextV6Address(value); }
        }
        
                
          
        public bool isIPTextV4AddressSelected () {
            return this.iPTextV4Address_selected ;
        }

        


        public void selectIPTextV4Address (byte[] val) {
            this.iPTextV4Address_ = val;
            this.iPTextV4Address_selected = true;
            
            
                    this.iPTextV6Address_selected = false;
                            
        }
        
          
        public bool isIPTextV6AddressSelected () {
            return this.iPTextV6Address_selected ;
        }

        


        public void selectIPTextV6Address (byte[] val) {
            this.iPTextV6Address_ = val;
            this.iPTextV6Address_selected = true;
            
            
                    this.iPTextV4Address_selected = false;
                            
        }
        
  

            public void initWithDefaults()
	    {
	    }

            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(IPTextRepresentedAddress));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}