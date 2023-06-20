CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Assigner] NVARCHAR(50) NOT NULL, 
    [AssignedTo] NVARCHAR(50) NOT NULL, 
    [TypeOf] NVARCHAR(50) NOT NULL, 
    [Initiation] DATE NOT NULL, 
    [Deadline] DATE NOT NULL
)
