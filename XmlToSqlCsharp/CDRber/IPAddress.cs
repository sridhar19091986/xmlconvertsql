
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
    [ASN1Choice ( Name = "IPAddress") ]
    public class IPAddress : IASN1PreparedElement {
                    
        
	private IPBinaryAddress iPBinaryAddress_ ;
        private bool  iPBinaryAddress_selected = false ;
        
        
        
        [ASN1Element ( Name = "iPBinaryAddress", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public IPBinaryAddress IPBinaryAddress
        {
            get { return iPBinaryAddress_; }
            set { selectIPBinaryAddress(value); }
        }
        
                
          
        
	private IPTextRepresentedAddress iPTextRepresentedAddress_ ;
        private bool  iPTextRepresentedAddress_selected = false ;
        
        
        
        [ASN1Element ( Name = "iPTextRepresentedAddress", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public IPTextRepresentedAddress IPTextRepresentedAddress
        {
            get { return iPTextRepresentedAddress_; }
            set { selectIPTextRepresentedAddress(value); }
        }
        
                
          
        public bool isIPBinaryAddressSelected () {
            return this.iPBinaryAddress_selected ;
        }

        


        public void selectIPBinaryAddress (IPBinaryAddress val) {
            this.iPBinaryAddress_ = val;
            this.iPBinaryAddress_selected = true;
            
            
                    this.iPTextRepresentedAddress_selected = false;
                            
        }
        
          
        public bool isIPTextRepresentedAddressSelected () {
            return this.iPTextRepresentedAddress_selected ;
        }

        


        public void selectIPTextRepresentedAddress (IPTextRepresentedAddress val) {
            this.iPTextRepresentedAddress_ = val;
            this.iPTextRepresentedAddress_selected = true;
            
            
                    this.iPBinaryAddress_selected = false;
                            
        }
        
  

            public void initWithDefaults()
	    {
	    }

            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(IPAddress));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}