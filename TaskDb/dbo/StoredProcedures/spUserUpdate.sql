CREATE PROCEDURE [dbo].[spUserUpdate]
	@id int,
	@Assigner nvarchar(50),
	@AssignedTo nvarchar(50),
	@TypeOf nvarchar(50),
	@Initiation date ,
	@Deadline date
	
AS
begin
	update dbo.[Task]
	set
	Assigner  = @Assigner,
	AssignedTo = @AssignedTo,
	TypeOf = @TypeOf,
	Initiation = @Initiation,
	Deadline  = @Deadline
	where
	Id = @Id;
end
