CREATE PROCEDURE [dbo].[spTask_Get]
@Id int
AS
begin
	SELECT * from dbo.[Task]
	where Id = @Id;
end
