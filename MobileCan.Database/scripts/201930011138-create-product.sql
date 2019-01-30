
create table Product(
ProductId int identity(1,1) Primary key,
CategoryId int NOT NULL ,
FOREIGN KEY (CategoryId) REFERENCES Category(Id) ,
Name nvarchar(200),
CreatedBy  nvarchar(200),
CreatedOn  Datetime default(getDate()),
ModifiedBy  nvarchar(200),
ModifiedOn  Datetime default(getDate()),
)

