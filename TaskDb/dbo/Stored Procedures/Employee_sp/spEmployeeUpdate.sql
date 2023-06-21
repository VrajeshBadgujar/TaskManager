CREATE PROCEDURE [dbo].[spEmployeeUpdate]
	@empId smallint,
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@isManager bit
AS
begin
	update dbo.Employee
	set 
	FirstName = @firstName,
	LastName = @lastName,
	IsManager = @isManager
	where
	EmployeeId = @empId;
end
