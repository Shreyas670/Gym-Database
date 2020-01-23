﻿CREATE TABLE MEMBER
(
	[MemberId] VARCHAR(10) NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(20) NULL, 
    [Contact] INT NULL, 
    [BranchId] VARCHAR(10) NULL, 
    [TrainerId] VARCHAR(10) NULL, 
    CONSTRAINT [FKP3] FOREIGN KEY ([BranchId]) REFERENCES [BRANCH]([BranchId]), 
    CONSTRAINT [FKP4] FOREIGN KEY ([TrainerId]) REFERENCES [TRAINER]([TrainerId])
)
