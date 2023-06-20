CREATE PROCEDURE [dbo].[spTask_Delete]
	@Id int
AS
begin
	Delete  
	from dbo.[Task]
	where Id = @Id;
end
