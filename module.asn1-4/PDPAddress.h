/*
 * Generated by asn1c-0.9.22 (http://lionet.info/asn1c)
 * From ASN.1 module "CmccGPRSber130"
 * 	found in "module.asn1"
 * 	`asn1c -S/skeletons`
 */

#ifndef	_PDPAddress_H_
#define	_PDPAddress_H_


#include <asn_application.h>

/* Including external dependencies */
#include "IPAddress.h"
#include "ETSIAddress.h"
#include <constr_CHOICE.h>

#ifdef __cplusplus
extern "C" {
#endif

/* Dependencies */
typedef enum PDPAddress_PR {
	PDPAddress_PR_NOTHING,	/* No components present */
	PDPAddress_PR_iPAddress,
	PDPAddress_PR_eTSIAddress
} PDPAddress_PR;

/* PDPAddress */
typedef struct PDPAddress {
	PDPAddress_PR present;
	union PDPAddress_u {
		IPAddress_t	 iPAddress;
		ETSIAddress_t	 eTSIAddress;
	} choice;
	
	/* Context for parsing across buffer boundaries */
	asn_struct_ctx_t _asn_ctx;
} PDPAddress_t;

/* Implementation */
extern asn_TYPE_descriptor_t asn_DEF_PDPAddress;

#ifdef __cplusplus
}
#endif

#endif	/* _PDPAddress_H_ */
