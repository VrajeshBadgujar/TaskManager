CREATE PROCEDURE [dbo].[spEmployee_Get]
@Id smallint
AS
begin
	SELECT * from dbo.[Employee]
	where EmployeeId = @Id;
end
