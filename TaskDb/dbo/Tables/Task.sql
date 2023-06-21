CREATE TABLE [dbo].[Task] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Assigner]   SMALLINT      NULL,
    [AssignedTo] SMALLINT      NULL,
    [TypeOf]     NVARCHAR (50) NOT NULL,
    [Initiation] DATETIME      NOT NULL,
    [Deadline]   DATETIME      NOT NULL,
    CONSTRAINT [PK__Task__3214EC07CED74E7E] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Assigner] FOREIGN KEY ([Assigner]) REFERENCES [dbo].[Employee] ([EmployeeId]),
    CONSTRAINT [FK_Task_AssignedTo] FOREIGN KEY ([AssignedTo]) REFERENCES [dbo].[Employee] ([EmployeeId])
);

