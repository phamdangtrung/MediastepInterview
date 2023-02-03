CREATE TABLE [dbo].[Student]
(
	[Id]			INT				NOT NULL	PRIMARY KEY IDENTITY(1, 1),
	[FullName]		NVARCHAR(100)	NOT NULL,
	[DateOfBirth]	DATE		NOT NULL,
	[Archived]		BIT				NOT NULL	DEFAULT (0)
)
