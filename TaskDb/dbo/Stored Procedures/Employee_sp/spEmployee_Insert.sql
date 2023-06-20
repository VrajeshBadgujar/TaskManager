CREATE PROCEDURE [dbo].[spEmployee_Insert]
	@empId int,
	@firstName nvarchar(50),
	@lastName nvarchar(50)
AS
begin
	insert into dbo.Employee (EmployeeId, FirstName, LastName)
	values
	(@empId, @firstName, @lastName);
end
