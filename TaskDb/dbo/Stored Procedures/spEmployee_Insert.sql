CREATE PROCEDURE [dbo].[sp_InsertEmployee]
	@empId int,
	@firstName nvarchar(50),
	@lastName nvarchar(50)
AS
begin
insert into dbo.Employee (EmployeeId, FirstName, LastName)
values
(@empId, @firstName, @lastName)
end
	
