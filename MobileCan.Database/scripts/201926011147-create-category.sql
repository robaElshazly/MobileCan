create table Category(
Id int identity(1,1) Primary key,
Name nvarchar(200),
CreatedBy  nvarchar(200),
CreatedOn  Datetime default(getDate()),
ModifiedBy  nvarchar(200),
ModifiedOn  Datetime default(getDate()),
)