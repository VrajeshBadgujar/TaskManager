CREATE PROCEDURE [dbo].[spTask_Insert]
	@Assigner smallint,
	@AssignedTo smallint,
	@TypeOf nvarchar(50),
	@Initiation datetime ,
	@Deadline datetime

AS
begin
	insert into dbo.[Task] (Assigner, AssignedTo, TypeOf, Initiation, Deadline)
	values (@Assigner, @AssignedTo, @TypeOf, @Initiation, @Deadline);
	end