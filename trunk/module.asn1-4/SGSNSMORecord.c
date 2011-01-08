/*
 * Generated by asn1c-0.9.22 (http://lionet.info/asn1c)
 * From ASN.1 module "CmccGPRSber130"
 * 	found in "module.asn1"
 * 	`asn1c -S/skeletons`
 */

#include <asn_internal.h>

#include "SGSNSMORecord.h"

static asn_TYPE_member_t asn_MBR_SGSNSMORecord_1[] = {
	{ ATF_NOFLAGS, 0, offsetof(struct SGSNSMORecord, recordType),
		(ASN_TAG_CLASS_CONTEXT | (0 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_CallEventRecordType,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"recordType"
		},
	{ ATF_NOFLAGS, 0, offsetof(struct SGSNSMORecord, servedIMSI),
		(ASN_TAG_CLASS_CONTEXT | (1 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_IMSI,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"servedIMSI"
		},
	{ ATF_POINTER, 4, offsetof(struct SGSNSMORecord, servedIMEI),
		(ASN_TAG_CLASS_CONTEXT | (2 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_IMEI,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"servedIMEI"
		},
	{ ATF_POINTER, 3, offsetof(struct SGSNSMORecord, servedMSISDN),
		(ASN_TAG_CLASS_CONTEXT | (3 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_MSISDN,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"servedMSISDN"
		},
	{ ATF_POINTER, 2, offsetof(struct SGSNSMORecord, msNetworkCapability),
		(ASN_TAG_CLASS_CONTEXT | (4 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_MSNetworkCapability,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"msNetworkCapability"
		},
	{ ATF_POINTER, 1, offsetof(struct SGSNSMORecord, serviceCentre),
		(ASN_TAG_CLASS_CONTEXT | (5 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_AddressString,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"serviceCentre"
		},
	{ ATF_NOFLAGS, 0, offsetof(struct SGSNSMORecord, recordingEntity),
		(ASN_TAG_CLASS_CONTEXT | (6 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_RecordingEntity,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"recordingEntity"
		},
	{ ATF_POINTER, 4, offsetof(struct SGSNSMORecord, locationArea),
		(ASN_TAG_CLASS_CONTEXT | (7 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_LocationAreaCode,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"locationArea"
		},
	{ ATF_POINTER, 3, offsetof(struct SGSNSMORecord, routingArea),
		(ASN_TAG_CLASS_CONTEXT | (8 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_RoutingAreaCode,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"routingArea"
		},
	{ ATF_POINTER, 2, offsetof(struct SGSNSMORecord, cellIdentity),
		(ASN_TAG_CLASS_CONTEXT | (9 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_CellId,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"cellIdentity"
		},
	{ ATF_POINTER, 1, offsetof(struct SGSNSMORecord, messageReference),
		(ASN_TAG_CLASS_CONTEXT | (10 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_MessageReference,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"messageReference"
		},
	{ ATF_NOFLAGS, 0, offsetof(struct SGSNSMORecord, originationTime),
		(ASN_TAG_CLASS_CONTEXT | (11 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_TimeStamp,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"originationTime"
		},
	{ ATF_POINTER, 4, offsetof(struct SGSNSMORecord, smsResult),
		(ASN_TAG_CLASS_CONTEXT | (12 << 2)),
		+1,	/* EXPLICIT tag at current level */
		&asn_DEF_SMSResult,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"smsResult"
		},
	{ ATF_POINTER, 3, offsetof(struct SGSNSMORecord, recordExtensions),
		(ASN_TAG_CLASS_CONTEXT | (13 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_ManagementExtensions,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"recordExtensions"
		},
	{ ATF_POINTER, 2, offsetof(struct SGSNSMORecord, nodeID),
		(ASN_TAG_CLASS_CONTEXT | (14 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_NodeID,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"nodeID"
		},
	{ ATF_POINTER, 1, offsetof(struct SGSNSMORecord, localSequenceNumber),
		(ASN_TAG_CLASS_CONTEXT | (15 << 2)),
		-1,	/* IMPLICIT tag at current level */
		&asn_DEF_LocalSequenceNumber,
		0,	/* Defer constraints checking to the member type */
		0,	/* PER is not compiled, use -gen-PER */
		0,
		"localSequenceNumber"
		},
};
static ber_tlv_tag_t asn_DEF_SGSNSMORecord_tags_1[] = {
	(ASN_TAG_CLASS_UNIVERSAL | (17 << 2))
};
static asn_TYPE_tag2member_t asn_MAP_SGSNSMORecord_tag2el_1[] = {
    { (ASN_TAG_CLASS_CONTEXT | (0 << 2)), 0, 0, 0 }, /* recordType at 100 */
    { (ASN_TAG_CLASS_CONTEXT | (1 << 2)), 1, 0, 0 }, /* servedIMSI at 101 */
    { (ASN_TAG_CLASS_CONTEXT | (2 << 2)), 2, 0, 0 }, /* servedIMEI at 102 */
    { (ASN_TAG_CLASS_CONTEXT | (3 << 2)), 3, 0, 0 }, /* servedMSISDN at 103 */
    { (ASN_TAG_CLASS_CONTEXT | (4 << 2)), 4, 0, 0 }, /* msNetworkCapability at 104 */
    { (ASN_TAG_CLASS_CONTEXT | (5 << 2)), 5, 0, 0 }, /* serviceCentre at 105 */
    { (ASN_TAG_CLASS_CONTEXT | (6 << 2)), 6, 0, 0 }, /* recordingEntity at 106 */
    { (ASN_TAG_CLASS_CONTEXT | (7 << 2)), 7, 0, 0 }, /* locationArea at 107 */
    { (ASN_TAG_CLASS_CONTEXT | (8 << 2)), 8, 0, 0 }, /* routingArea at 108 */
    { (ASN_TAG_CLASS_CONTEXT | (9 << 2)), 9, 0, 0 }, /* cellIdentity at 109 */
    { (ASN_TAG_CLASS_CONTEXT | (10 << 2)), 10, 0, 0 }, /* messageReference at 110 */
    { (ASN_TAG_CLASS_CONTEXT | (11 << 2)), 11, 0, 0 }, /* originationTime at 111 */
    { (ASN_TAG_CLASS_CONTEXT | (12 << 2)), 12, 0, 0 }, /* smsResult at 112 */
    { (ASN_TAG_CLASS_CONTEXT | (13 << 2)), 13, 0, 0 }, /* recordExtensions at 113 */
    { (ASN_TAG_CLASS_CONTEXT | (14 << 2)), 14, 0, 0 }, /* nodeID at 114 */
    { (ASN_TAG_CLASS_CONTEXT | (15 << 2)), 15, 0, 0 } /* localSequenceNumber at 115 */
};
static uint8_t asn_MAP_SGSNSMORecord_mmap_1[(16 + (8 * sizeof(unsigned int)) - 1) / 8] = {
	(1 << 7) | (1 << 6) | (0 << 5) | (0 << 4) | (0 << 3) | (0 << 2) | (1 << 1) | (0 << 0),
	(0 << 7) | (0 << 6) | (0 << 5) | (1 << 4) | (0 << 3) | (0 << 2) | (0 << 1) | (0 << 0)
};
static asn_SET_specifics_t asn_SPC_SGSNSMORecord_specs_1 = {
	sizeof(struct SGSNSMORecord),
	offsetof(struct SGSNSMORecord, _asn_ctx),
	offsetof(struct SGSNSMORecord, _presence_map),
	asn_MAP_SGSNSMORecord_tag2el_1,
	16,	/* Count of tags in the map */
	asn_MAP_SGSNSMORecord_tag2el_1,	/* Same as above */
	16,	/* Count of tags in the CXER map */
	0,	/* Whether extensible */
	(unsigned int *)asn_MAP_SGSNSMORecord_mmap_1	/* Mandatory elements map */
};
asn_TYPE_descriptor_t asn_DEF_SGSNSMORecord = {
	"SGSNSMORecord",
	"SGSNSMORecord",
	SET_free,
	SET_print,
	SET_constraint,
	SET_decode_ber,
	SET_encode_der,
	SET_decode_xer,
	SET_encode_xer,
	0, 0,	/* No PER support, use "-gen-PER" to enable */
	0,	/* Use generic outmost tag fetcher */
	asn_DEF_SGSNSMORecord_tags_1,
	sizeof(asn_DEF_SGSNSMORecord_tags_1)
		/sizeof(asn_DEF_SGSNSMORecord_tags_1[0]), /* 1 */
	asn_DEF_SGSNSMORecord_tags_1,	/* Same as above */
	sizeof(asn_DEF_SGSNSMORecord_tags_1)
		/sizeof(asn_DEF_SGSNSMORecord_tags_1[0]), /* 1 */
	0,	/* No PER visible constraints */
	asn_MBR_SGSNSMORecord_1,
	16,	/* Elements count */
	&asn_SPC_SGSNSMORecord_specs_1	/* Additional specs */
};

