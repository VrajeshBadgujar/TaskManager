CREATE PROCEDURE [dbo].[spEmployee_Insert]
	@empId smallint,
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@isManager bit
AS
begin
	insert into dbo.Employee (EmployeeId, FirstName, LastName, IsManager)
	values
	(@empId, @firstName, @lastName, @isManager);
end
