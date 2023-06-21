CREATE PROCEDURE [dbo].[spTaskUpdate]
	@id int,
	@Assigner smallint,
	@AssignedTo smallint,
	@TypeOf nvarchar(50),
	@Initiation datetime ,
	@Deadline datetime
	
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
	Id = @id;
end