CREATE PROCEDURE [dbo].[spEmployeeUpdate]
	@empId int,
	@firstName nvarchar(50),
	@lastName nvarchar(50)
AS
begin
	update dbo.Employee
	set 
	FirstName = @firstName,
	LastName = @lastName
	where
	EmployeeId = @empId;
end
