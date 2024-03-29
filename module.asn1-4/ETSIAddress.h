/*
 * Generated by asn1c-0.9.22 (http://lionet.info/asn1c)
 * From ASN.1 module "CmccGPRSber130"
 * 	found in "module.asn1"
 * 	`asn1c -S/skeletons`
 */

#ifndef	_ETSIAddress_H_
#define	_ETSIAddress_H_


#include <asn_application.h>

/* Including external dependencies */
#include "AddressString.h"

#ifdef __cplusplus
extern "C" {
#endif

/* ETSIAddress */
typedef AddressString_t	 ETSIAddress_t;

/* Implementation */
extern asn_TYPE_descriptor_t asn_DEF_ETSIAddress;
asn_struct_free_f ETSIAddress_free;
asn_struct_print_f ETSIAddress_print;
asn_constr_check_f ETSIAddress_constraint;
ber_type_decoder_f ETSIAddress_decode_ber;
der_type_encoder_f ETSIAddress_encode_der;
xer_type_decoder_f ETSIAddress_decode_xer;
xer_type_encoder_f ETSIAddress_encode_xer;

#ifdef __cplusplus
}
#endif

#endif	/* _ETSIAddress_H_ */
