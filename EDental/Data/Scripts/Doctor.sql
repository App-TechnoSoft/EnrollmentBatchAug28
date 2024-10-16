create table Doctor
(
	Id int primary key identity(1,1),
	FullName nvarchar(100) not null,
	Address nvarchar(200) not null,
	Phone varchar(20) null, 
	NDCNumber nvarchar(100) not null, 
	Qualification varchar(200), 
	Specialization varchar(200), 
	Gender int, 
	DOB Datetime2
)

insert into Doctor
values ('Dr. James', 'Kathmandu, Nepal', '9841234563', 'ABC34784FG', 'MDS MS', 'Dental Surgery', 1, '1980/12/12')

select * from Doctor