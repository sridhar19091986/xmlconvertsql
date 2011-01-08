/*
 * Generated by asn1c-0.9.22 (http://lionet.info/asn1c)
 * From ASN.1 module "CmccGPRSber130"
 * 	found in "module.asn1"
 * 	`asn1c -S/skeletons`
 */

#ifndef	_CauseForRecClosing_H_
#define	_CauseForRecClosing_H_


#include <asn_application.h>

/* Including external dependencies */
#include <NativeEnumerated.h>

#ifdef __cplusplus
extern "C" {
#endif

/* Dependencies */
typedef enum CauseForRecClosing {
	CauseForRecClosing_normalRelease	= 0,
	CauseForRecClosing_abnormalRelease	= 4,
	CauseForRecClosing_volumeLimit	= 16,
	CauseForRecClosing_timeLimit	= 17,
	CauseForRecClosing_sGSNChange	= 18,
	CauseForRecClosing_maxChangeCond	= 19
} e_CauseForRecClosing;

/* CauseForRecClosing */
typedef long	 CauseForRecClosing_t;

/* Implementation */
extern asn_TYPE_descriptor_t asn_DEF_CauseForRecClosing;
asn_struct_free_f CauseForRecClosing_free;
asn_struct_print_f CauseForRecClosing_print;
asn_constr_check_f CauseForRecClosing_constraint;
ber_type_decoder_f CauseForRecClosing_decode_ber;
der_type_encoder_f CauseForRecClosing_encode_der;
xer_type_decoder_f CauseForRecClosing_decode_xer;
xer_type_encoder_f CauseForRecClosing_encode_xer;

#ifdef __cplusplus
}
#endif

#endif	/* _CauseForRecClosing_H_ */
