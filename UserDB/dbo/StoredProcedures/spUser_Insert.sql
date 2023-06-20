CREATE PROCEDURE [dbo].[spUser_Insert]
	@Assigner nvarchar(50),
	@AssignedTo nvarchar(50),
	@TypeOf nvarchar(50),
	@Initiation date ,
	@Deadline date

AS
begin
	insert into dbo.[User] (Assigner, AssignedTo, TypeOf, Initiation, Deadline)
	values (@Assigner, @AssignedTo, @TypeOf, @Initiation, @Deadline);
	end