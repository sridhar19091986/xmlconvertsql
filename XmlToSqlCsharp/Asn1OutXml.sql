IF EXISTS (SELECT * FROM DBO.SYSOBJECTS WHERE ID = OBJECT_ID(N'[IP_Stream].[dbo].[SEQUENCE]') AND OBJECTPROPERTY(ID, N'ISUSERTABLE') = 1) BEGIN DROP TABLE [IP_Stream].[dbo].[SEQUENCE]END ;

IF EXISTS (SELECT * FROM DBO.SYSOBJECTS WHERE ID = OBJECT_ID(N'[IP_Stream].[dbo].[CONTEXT_21]') AND OBJECTPROPERTY(ID, N'ISUSERTABLE') = 1) BEGIN DROP TABLE [IP_Stream].[dbo].[CONTEXT_21]END ;

IF EXISTS (SELECT * FROM DBO.SYSOBJECTS WHERE ID = OBJECT_ID(N'[IP_Stream].[dbo].[CONTEXT_28]') AND OBJECTPROPERTY(ID, N'ISUSERTABLE') = 1) BEGIN DROP TABLE [IP_Stream].[dbo].[CONTEXT_28]END ;

CREATE TABLE [IP_Stream].[dbo].[SEQUENCE] ( [CONTEXT_2] char (255)  NOT NULL , [CONTEXT_3] char (255)  NOT NULL , [CONTEXT_5] char (255)  NOT NULL , [CONTEXT_1] char (255)  NOT NULL , [CONTEXT_8] char (255)  NOT NULL , [CONTEXT_11] char (255)  NULL , [CONTEXT_13] char (255)  NOT NULL , [CONTEXT_14] char (255)  NOT NULL , [CONTEXT_17] char (255)  NOT NULL ) ;

CREATE TABLE [IP_Stream].[dbo].[CONTEXT_21] ( [CONTEXT_3] char (255)  NOT NULL , [CONTEXT_5] char (255)  NOT NULL , [CONTEXT_7] char (255)  NOT NULL , [CONTEXT_8] char (255)  NOT NULL , [CONTEXT_11] char (255)  NOT NULL , [CONTEXT_13] char (255)  NOT NULL , [CONTEXT_14] char (255)  NOT NULL , [CONTEXT_15] char (255)  NOT NULL , [CONTEXT_17] char (255)  NOT NULL , [CONTEXT_18] char (255)  NOT NULL , [CONTEXT_22] char (255)  NOT NULL , [CONTEXT_23] char (255)  NOT NULL , [CONTEXT_24] char (255)  NOT NULL , [CONTEXT_20] char (255)  NOT NULL , [CONTEXT_27] char (255)  NOT NULL , [CONTEXT_29] char (255)  NOT NULL , [CONTEXT_31] char (255)  NOT NULL , [CONTEXT_32] char (255)  NOT NULL ) ;

CREATE TABLE [IP_Stream].[dbo].[CONTEXT_28] ( [CONTEXT_3] char (255)  NOT NULL , [CONTEXT_5] char (255)  NOT NULL , [CONTEXT_7] char (255)  NOT NULL , [CONTEXT_8] char (255)  NOT NULL , [CONTEXT_11] char (255)  NOT NULL , [CONTEXT_13] char (255)  NOT NULL , [CONTEXT_14] char (255)  NOT NULL , [CONTEXT_15] char (255)  NOT NULL , [CONTEXT_17] char (255)  NOT NULL , [CONTEXT_18] char (255)  NOT NULL , [CONTEXT_22] char (255)  NOT NULL , [CONTEXT_23] char (255)  NOT NULL , [CONTEXT_24] char (255)  NOT NULL , [CONTEXT_20] char (255)  NOT NULL , [CONTEXT_27] char (255)  NOT NULL ) ;

