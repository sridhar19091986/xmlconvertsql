/*
 * Generated by asn1c-0.9.22 (http://lionet.info/asn1c)
 * From ASN.1 module "CmccGPRSber130"
 * 	found in "module.asn1"
 * 	`asn1c -S/skeletons`
 */

#ifndef	_ListOfTrafficVolumesC_H_
#define	_ListOfTrafficVolumesC_H_


#include <asn_application.h>

/* Including external dependencies */
#include "ChangeOfCharConditionC.h"
#include <constr_SEQUENCE.h>

#ifdef __cplusplus
extern "C" {
#endif

/* ListOfTrafficVolumesC */
typedef struct ListOfTrafficVolumesC {
	ChangeOfCharConditionC_t	 peak;
	ChangeOfCharConditionC_t	 offPeak;
	
	/* Context for parsing across buffer boundaries */
	asn_struct_ctx_t _asn_ctx;
} ListOfTrafficVolumesC_t;

/* Implementation */
extern asn_TYPE_descriptor_t asn_DEF_ListOfTrafficVolumesC;

#ifdef __cplusplus
}
#endif

#endif	/* _ListOfTrafficVolumesC_H_ */