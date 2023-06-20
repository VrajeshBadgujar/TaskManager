CREATE PROCEDURE [dbo].[spEmployee_Delete]
	@Id int
AS
begin
	Delete  
	from dbo.[Employee]
	where EmployeeId = @Id;
end
