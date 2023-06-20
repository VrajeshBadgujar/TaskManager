CREATE PROCEDURE [dbo].[spTask_GetAll]
AS
begin
      select Task.Id, AssignedTo, Assigner, TypeOf, Initiation,Deadline
      from dbo.[Task];
end
