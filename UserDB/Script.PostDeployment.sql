if not exists (select 1 from dbo.[User])
begin
insert into dbo.[User] (Assigner, AssignedTo, TypeOf, Intiation, Deadline)
values
('Yatin', 'Vrajesh', 'development', '2023-06-01', '2023-06-07'),
('Dipesh', 'Vrajesh', 'development', '2023-06-01',' 2023-06-07');

end