/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
if not exists (select 1 from dbo.[Task])
begin
insert into dbo.[Task] (Assigner, AssignedTo, TypeOf, Initiation, Deadline)
values
('101', '103', 'development', '2023-06-01', '2023-06-07'),
('102', '103', 'QA', '2023-06-01','2023-06-07');
end

