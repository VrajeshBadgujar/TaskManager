CREATE TABLE [dbo].[Task]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Assigner] INT NOT NULL, 
    [AssignedTo] INT NOT NULL, 
    [TypeOf] NVARCHAR(50) NOT NULL, 
    [Initiation] DATE NOT NULL, 
    [Deadline] DATE NOT NULL, 
    CONSTRAINT [FK_Assigner] FOREIGN KEY ([Assigner]) REFERENCES [Employee]([EmployeeId]), 
    CONSTRAINT [FK_Task_AssignedTo] FOREIGN KEY ([AssignedTo]) REFERENCES [Employee]([EmployeeId])
	)