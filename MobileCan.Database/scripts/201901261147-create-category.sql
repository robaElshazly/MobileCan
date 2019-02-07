create table Category(
Id int identity(1,1) Primary key,
Name nvarchar(200),
CreatedBy  nvarchar(200),
CreatedOn  Datetime default(getDate()),
ModifiedBy  nvarchar(200),
ModifiedOn  Datetime default(getDate()),
)
insert into Category (name,CreatedBy,ModifiedBy) values 
('Mobile','data seed','data seed'),
('Tablets','data seed','data seed'),
('Accessories','data seed','data seed'),
('Wearables','data seed','data seed')