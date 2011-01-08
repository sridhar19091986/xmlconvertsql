

CmccGPRSber130 DEFINITIONS IMPLICIT TAGS ::=
BEGIN

CallEventRecord ::= CHOICE 
{
	sgsnPDPRecord		[0] SGSNPDPRecord,
	ggsnPDPRecord		[1] GGSNPDPRecord,
	sgsnMMRecord		[2] SGSNMMRecord,
	sgsnSMORecord		[3] SGSNSMORecord,
	sgsnSMTRecord		[4] SGSNSMTRecord
}

GGSNPDPRecord ::= SET
{
	recordType			[0] CallEventRecordType,
	networkInitiation		[1] NetworkInitiatedPDPContext OPTIONAL,
	anonymousAccessIndicator		[2] BOOLEAN OPTIONAL,
	servedIMSI			[3] IMSI,
	ggsnAddress			[4] EXPLICIT GSNAddress,
	chargingID			[5] ChargingID,
	sgsnAddress			[6] EXPLICIT SEQUENCE OF GSNAddress,
	accessPointNameNI		[7] AccessPointNameNI,
	pdpType			[8] PDPType,
	servedPDPAddress		[9] EXPLICIT PDPAddress OPTIONAL,
	remotePDPAddress		[10] EXPLICIT SEQUENCE OF PDPAddress OPTIONAL,
	dynamicAddressFlag      [11] DynamicAddressFlag OPTIONAL,
	listOfTrafficVolumes	[12] SEQUENCE OF ChangeOfCharCondition,
	recordOpeningTime		[13] TimeStamp,
	duration			[14] INTEGER,
	causeForRecClosing	[15] CauseForRecClosing,
	recordSequenceNumber	[17] RECORDSequenceNumber OPTIONAL,
	nodeID			[18] NodeID OPTIONAL,
	recordExtensions		[19] ManagementExtensions OPTIONAL,
	apnSelectionMode		[21] APNSelectionMode OPTIONAL,
	listOfTrafficVolumesC	[27] ListOfTrafficVolumesC,
	durationC			[28] CallDurationC,
	servedMSISDN			[29] MSISDN OPTIONAL,
	consolidationResult	[30] ConsolidationResult
}

SGSNMMRecord ::= SET
{
	recordType			[0] CallEventRecordType,
	servedIMSI			[1] IMSI,
	servedIMEI			[2] IMEI OPTIONAL,
	sgsnAddress			[3] EXPLICIT GSNAddress,
	msNetworkCapability	[4] MSNetworkCapability OPTIONAL,
	routingArea			[5] RoutingAreaCode OPTIONAL,
	locationAreaCode		[6] LocationAreaCode OPTIONAL,
	cellIdentity		[7] CellId OPTIONAL,
	changeLocation		[8] SEQUENCE OF ChangeLocation OPTIONAL,
	recordOpeningTime		[9] TimeStamp,
	duration			[10] CallDuration OPTIONAL, 
	sgsnChange			[11] SGSNChange OPTIONAL,
	causeForRecClosing	[12] CauseForRecClosing,
	diagnostics			[13] Diagnostics OPTIONAL,
	recordSequenceNumber	[14] INTEGER OPTIONAL,
	nodeID			[15] NodeID OPTIONAL,
	recordExtensions		[16] ManagementExtensions OPTIONAL,
	localSequenceNumber	[17] LocalSequenceNumber OPTIONAL
}

SGSNPDPRecord ::= SET
{
	recordType			[0] CallEventRecordType,
	networkInitiation		[1] NetworkInitiatedPDPContext OPTIONAL,
	anonymousAccessIndicator		[2] BOOLEAN OPTIONAL,
	servedIMSI			[3] IMSI,
	servedIMEI			[4] IMEI OPTIONAL,
	sgsnAddress			[5] EXPLICIT SEQUENCE OF GSNAddress,
	msNetworkCapability	[6] MSNetworkCapability OPTIONAL,
	routingArea			[7] RoutingAreaCode OPTIONAL,
	locationAreaCode		[8] LocationAreaCode OPTIONAL,
	cellIdentity		[9] CellId OPTIONAL,
	chargingID			[10] ChargingID,
	ggsnAddressUsed		[11] EXPLICIT GSNAddress,
	accessPointNameNI		[12] AccessPointNameNI,
	pdpType			[13] PDPType,
	servedPDPAddress		[14] EXPLICIT PDPAddress OPTIONAL,
	listOfTrafficVolumes	[15] SEQUENCE OF ChangeOfCharCondition,
	recordOpeningTime		[16] TimeStamp,
	duration			[17] CallDuration,
	sgsnChange			[18] SGSNChange OPTIONAL,
	causeForRecClosing	[19] CauseForRecClosing,
	recordSequenceNumber	[21] SEQUENCE OF RECORDSequenceNumber OPTIONAL,
	nodeID			[22] NodeID OPTIONAL,
	recordExtensions		[23] ManagementExtensions OPTIONAL,
	apnSelectionMode		[25] APNSelectionMode OPTIONAL,
	accessPointNameOI		[26] AccessPointNameOI OPTIONAL,
	listOfTrafficVolumesC	[27] ListOfTrafficVolumesC,
	durationC			[28] CallDurationC,
	servedMSISDN		[29] MSISDN OPTIONAL,
	consolidationResult	[30] ConsolidationResult
}

SGSNSMORecord ::= SET
{
	recordType			[0] CallEventRecordType,
	servedIMSI			[1] IMSI,
	servedIMEI			[2] IMEI OPTIONAL,
	servedMSISDN		[3] MSISDN OPTIONAL,
	msNetworkCapability	[4] MSNetworkCapability OPTIONAL,
	serviceCentre		[5] AddressString OPTIONAL,
	recordingEntity		[6] RecordingEntity,
	locationArea		[7] LocationAreaCode OPTIONAL,
	routingArea			[8] RoutingAreaCode OPTIONAL,
	cellIdentity		[9] CellId OPTIONAL,
	messageReference		[10] MessageReference OPTIONAL,
	originationTime			[11] TimeStamp,
	smsResult			[12] EXPLICIT SMSResult OPTIONAL,
	recordExtensions		[13] ManagementExtensions OPTIONAL, 
	nodeID			[14] NodeID OPTIONAL,
	localSequenceNumber	[15] LocalSequenceNumber OPTIONAL
}

SGSNSMTRecord ::= SET
{
	recordType			[0] CallEventRecordType,
	servedIMSI			[1] IMSI,
	servedIMEI			[2] IMEI OPTIONAL,
	servedMSISDN		[3] MSISDN OPTIONAL,
	msNetworkCapability	[4] MSNetworkCapability OPTIONAL,
	serviceCentre		[5] AddressString OPTIONAL,
	recordingEntity		[6] RecordingEntity,
	locationArea		[7] LocationAreaCode OPTIONAL,
	routingArea			[8] RoutingAreaCode OPTIONAL,
	cellIdentity		[9] CellId OPTIONAL,
	originationTime		[10] TimeStamp,
	smsResult			[11] EXPLICIT SMSResult OPTIONAL,
	recordExtensions		[12] ManagementExtensions OPTIONAL,
	nodeID			[13] NodeID OPTIONAL,
	localSequenceNumber	[14] LocalSequenceNumber OPTIONAL
}
------------------------------------------------------------------------------
--
--  COMMON DATA TYPES
--
------------------------------------------------------------------------------
AccessPointNameNI ::= IA5STRING (SIZE(1..63))
AccessPointNameOI ::= IA5STRING (SIZE(1..37))
AddressString ::= OCTET STRING (SIZE (1..20))
APNSelectionMode ::= ENUMERATED
{
	mSorNetworkProvidedSubscriptionVerified	(0),
	mSProvidedSubscriptionNotVerified	      (1),
	networkProvidedSubscriptionNotVerified	(2)
}
CallDuration ::= INTEGER
CallDurationC ::= SEQUENCE
{
	peak			      [0] INTEGER,
	offPeak			[1] INTEGER
}
CallEventRecordType ::= ENUMERATED
{
	sgsnPDPRecord		(18),
	ggsnPDPRecord		(19),
	sgsnMMRecord		(20),
	sgsnSMORecord		(21),
	sgsnSMTRecord		(22)
}
CauseForRecClosing ::= ENUMERATED
{
	normalRelease		(0),
	abnormalRelease		(4),
	volumeLimit			(16),
	timeLimit			(17),
	sGSNChange			(18),
	maxChangeCond		(19)
}
CellId ::= OCTET STRING (SIZE(2))
ChangeCondition ::= ENUMERATED
{
	qoSChange			(0),
	tariffTime			(1),
	recordClosure		(2)
}
ChangeLocation ::= SEQUENCE
{
	locationAreaCode		[0] LocationAreaCode,
	routingAreaCode		[1] RoutingAreaCode,
	cellId			[2] CellId OPTIONAL,
	changeTime			[3] TimeStamp
}
ChangeOfCharCondition ::= SEQUENCE
{
	qosRequested		[1] QoSInformation OPTIONAL,
	qosNegotiated		[2] QoSInformation OPTIONAL,
	dataVolumeGPRSUplink	[3] DataVolumeGPRS,
	dataVolumeGPRSDownlink	[4] DataVolumeGPRS,
	changeCondition		[5] ChangeCondition,
	changeTime			[6] TimeStamp
}
ChangeOfCharConditionC ::= SEQUENCE
{
	dataVolumeGPRSUplink	[1] DataVolumeGPRS,
	dataVolumeGPRSDownlink	[2] DataVolumeGPRS
}
ChargingID ::= INTEGER (0..4294967295)
ConsolidationResult ::= ENUMERATED
{
	normal			(0),
	notNormal			(1),
	forInterSGSNConsolidation		(2),
 	reachLimit			(3),
	onlyOneCDRGenerated	(4)
}
DataVolumeGPRS ::= INTEGER
DynamicAddressFlag ::= BOOLEAN
Diagnostics ::= CHOICE
{
	gsm0408Cause		[0] INTEGER,
	gsm0902MapErrorValue	[1] INTEGER,
	ccittQ767Cause		[2] INTEGER,
	networkSpecificCause	[3] ManagementExtension,
	manufacturerSpecificCause		[4] ManagementExtension
}
ETSIAddress ::= AddressString
GSNAddress ::= IPAddress
IMSI ::= TBCD STRING
IMEI ::= TBCD STRING (SIZE (8))
IPAddress ::= CHOICE
{
	iPBinaryAddress		IPBinaryAddress,
	iPTextRepresentedAddress		IPTextRepresentedAddress
}
IPBinaryAddress ::= CHOICE
{
	iPBinV4Address		[0] OCTET STRING (SIZE(4)),
	iPBinV6Address		[1] OCTET STRING (SIZE(16))
}
IPTextRepresentedAddress ::= CHOICE
{
	iPTextV4Address		[2] IA5STRING (SIZE(7..15)),
	iPTextV6Address		[3] IA5STRING (SIZE(15..45))
}
ListOfTrafficVolumesC ::= SEQUENCE
{
	peak			      [0] ChangeOfCharConditionC,
	offPeak			[1] ChangeOfCharConditionC
}
LocalSequenceNumber ::= INTEGER (0..4294967295)
LocationAreaCode ::= OCTET STRING (SIZE(2))
ManagementExtensions ::= SET OF ManagementExtension
ManagementExtension ::= NULL
MessageReference ::= OCTET STRING
MSISDN ::= TBCD STRING 
MSNetworkCapability ::= OCTET STRING (SIZE(1))
NetworkInitiatedPDPContext ::= BOOLEAN
NodeID ::= IA5STRING (SIZE(1..20))
PDPAddress ::= CHOICE
{
	iPAddress			[0] EXPLICIT IPAddress,
	eTSIAddress			[1] ETSIAddress
}
PDPType ::= OCTET STRING (SIZE(2))
QoSDelay ::= ENUMERATED
{
	delayClass1			(1),
	delayClass2			(2),
	delayClass3			(3),
	delayClass4			(4)
}
QoSInformation ::=SEQUENCE
{
	reliability			[0] QoSReliability,
	delay			      [1] QoSDelay,
	precedence			[2] QoSPrecedence,
	peakThroughput		[3] QoSPeakThroughput,
	meanThroughput		[4] QoSMeanThroughput
}
QoSMeanThroughput ::= ENUMERATED
{
	bestEffort			(0),
	mean100octetPh		(1),
	mean200octetPh		(2),
	mean500octetPh		(3),
	mean1000octetPh		(4),
	mean2000octetPh		(5),
	mean5000octetPh		(6),
	mean10000octetPh		(7),
	mean20000octetPh		(8),
	mean50000octetPh		(9),
	mean100000octetPh		(10),
	mean200000octetPh		(11),
	mean500000octetPh		(12),
	mean1000000octetPh	(13),
	mean2000000octetPh	(14),
	mean5000000octetPh	(15),
	mean10000000octetPh	(16),
	mean20000000octetPh	(17),
	mean50000000octetPh	(18)
}
QoSPeakThroughput ::= ENUMERATED
{
	unspecified			(0),
	upTo100OctetPs		(1),
	upTo200OctetPs		(2),
	upTo400OctetPs		(3),
	upTo800OctetPs		(4),
	upTo1600OctetPs		(5),
	upTo3200OctetPs		(6),
	upTo6400OctetPs		(7),
	upTo12800OctetPs		(8),
	upTo25600OctetPs		(9)
}
QoSPrecedence ::= ENUMERATED
{
	unspecified			(0),
	highPriority		(1),
	normalPriority		(2),
	lowPriority			(3)
}
QoSReliability ::= ENUMERATED
{
	unspecifiedReliability	(0),
	acknowledgedGTP		(1),
	unackGTPAcknowLLC		(2),
	unackGTPLLCAcknowRLC	(3),
	unackGTPLLCRLC		(4),
	unacknowUnprotectedData	(5)
}
RecordingEntity ::= AddressString
RecordNumber ::= INTEGER
RECORDSequenceNumber ::= SEQUENCE
{
	gsnAddress			[0] EXPLICIT GSNAddress,
	recordNumberList		[1] SEQUENCE OF RecordNumber
}
RoutingAreaCode ::= OCTET STRING (SIZE(1))
SGSNChange ::= BOOLEAN
SMSResult ::= Diagnostics
TimeStamp ::= OCTET STRING (SIZE(9))
-- The contents of this field are a compact form of the UTCTime format containing UTC time. The format is "YYMMDDhhmmssShhmm".
-- YY 	= 	Year 00 to 99		BCD encoded
-- MM 	= 	Month 01 to 12 	BCD encoded
-- DD 	=	Day 01 to 31		BCD encoded
-- hh	=	hour 00 to 23		BCD encoded
-- mm	=	minute 00 to 59	BCD encoded
-- ss	=	second 00 to 59	BCD encoded
-- S	=	Sign 0 = "+", "-"	ASCII encoded
-- hh	=	hour 00 to 23		BCD encoded
-- mm	=	minute 00 to 59	BCD encoded

END

