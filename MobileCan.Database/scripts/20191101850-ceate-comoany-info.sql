create table CompanyInfo(
Id int identity(1,1) Primary key,
Name nvarchar(200),
[Address] nvarchar(200),
[WorkingHours]  nvarchar(max),
[Phone] nvarchar(10)
)