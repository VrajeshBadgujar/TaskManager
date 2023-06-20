CREATE PROCEDURE [dbo].[spEmployee_Get]
@Id int
AS
begin
	SELECT * from dbo.[Employee]
	where EmployeeId = @Id;
end
