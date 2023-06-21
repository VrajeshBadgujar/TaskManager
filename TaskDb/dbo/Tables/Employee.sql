CREATE TABLE [dbo].[Employee] (
    [EmployeeId] SMALLINT      NOT NULL,
    [FirstName]  NVARCHAR (50) NOT NULL,
    [LastName]   NVARCHAR (50) NOT NULL,
    [IsManager]  BIT           NULL,
    CONSTRAINT [PK__tmp_ms_x__7AD04F1156479BE9] PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);


