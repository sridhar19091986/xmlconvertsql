/*
 * Generated by asn1c-0.9.22 (http://lionet.info/asn1c)
 * From ASN.1 module "CmccGPRSber130"
 * 	found in "module.asn1"
 * 	`asn1c -S/skeletons`
 */

#ifndef	_SGSNSMTRecord_H_
#define	_SGSNSMTRecord_H_


#include <asn_application.h>

/* Including external dependencies */
#include "CallEventRecordType.h"
#include "IMSI.h"
#include "IMEI.h"
#include "MSISDN.h"
#include "MSNetworkCapability.h"
#include "AddressString.h"
#include "RecordingEntity.h"
#include "LocationAreaCode.h"
#include "RoutingAreaCode.h"
#include "CellId.h"
#include "TimeStamp.h"
#include "NodeID.h"
#include "LocalSequenceNumber.h"
#include <constr_SET.h>

#ifdef __cplusplus
extern "C" {
#endif

/* Dependencies */

/*
 * Method of determining the components presence
 */
typedef enum SGSNSMTRecord_PR {
	SGSNSMTRecord_PR_recordType,	/* Member recordType is present */
	SGSNSMTRecord_PR_servedIMSI,	/* Member servedIMSI is present */
	SGSNSMTRecord_PR_servedIMEI,	/* Member servedIMEI is present */
	SGSNSMTRecord_PR_servedMSISDN,	/* Member servedMSISDN is present */
	SGSNSMTRecord_PR_msNetworkCapability,	/* Member msNetworkCapability is present */
	SGSNSMTRecord_PR_serviceCentre,	/* Member serviceCentre is present */
	SGSNSMTRecord_PR_recordingEntity,	/* Member recordingEntity is present */
	SGSNSMTRecord_PR_locationArea,	/* Member locationArea is present */
	SGSNSMTRecord_PR_routingArea,	/* Member routingArea is present */
	SGSNSMTRecord_PR_cellIdentity,	/* Member cellIdentity is present */
	SGSNSMTRecord_PR_originationTime,	/* Member originationTime is present */
	SGSNSMTRecord_PR_smsResult,	/* Member smsResult is present */
	SGSNSMTRecord_PR_recordExtensions,	/* Member recordExtensions is present */
	SGSNSMTRecord_PR_nodeID,	/* Member nodeID is present */
	SGSNSMTRecord_PR_localSequenceNumber,	/* Member localSequenceNumber is present */
} SGSNSMTRecord_PR;

/* Forward declarations */
struct Diagnostics;
struct ManagementExtensions;

/* SGSNSMTRecord */
typedef struct SGSNSMTRecord {
	CallEventRecordType_t	 recordType;
	IMSI_t	 servedIMSI;
	IMEI_t	*servedIMEI	/* OPTIONAL */;
	MSISDN_t	*servedMSISDN	/* OPTIONAL */;
	MSNetworkCapability_t	*msNetworkCapability	/* OPTIONAL */;
	AddressString_t	*serviceCentre	/* OPTIONAL */;
	RecordingEntity_t	 recordingEntity;
	LocationAreaCode_t	*locationArea	/* OPTIONAL */;
	RoutingAreaCode_t	*routingArea	/* OPTIONAL */;
	CellId_t	*cellIdentity	/* OPTIONAL */;
	TimeStamp_t	 originationTime;
	struct Diagnostics	*smsResult	/* OPTIONAL */;
	struct ManagementExtensions	*recordExtensions	/* OPTIONAL */;
	NodeID_t	*nodeID	/* OPTIONAL */;
	LocalSequenceNumber_t	*localSequenceNumber	/* OPTIONAL */;
	
	/* Presence bitmask: ASN_SET_ISPRESENT(pSGSNSMTRecord, SGSNSMTRecord_PR_x) */
	unsigned int _presence_map
		[((15+(8*sizeof(unsigned int))-1)/(8*sizeof(unsigned int)))];
	
	/* Context for parsing across buffer boundaries */
	asn_struct_ctx_t _asn_ctx;
} SGSNSMTRecord_t;

/* Implementation */
extern asn_TYPE_descriptor_t asn_DEF_SGSNSMTRecord;

#ifdef __cplusplus
}
#endif

/* Referred external types */
#include "SMSResult.h"
#include "ManagementExtensions.h"

#endif	/* _SGSNSMTRecord_H_ */
