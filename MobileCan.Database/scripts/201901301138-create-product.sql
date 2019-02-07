create table Product(
ProductId int identity(1,1) Primary key,
CategoryId int NOT NULL ,
FOREIGN KEY (CategoryId) REFERENCES Category(Id) ,
Name nvarchar(200),
Price money,
Rating float,
CreatedBy nvarchar(200),
CreatedOn Datetime default(getDate()),
ModifiedBy nvarchar(200),
ModifiedOn Datetime default(getDate()),
)
go
insert into Product (name,CategoryId,Price,rating,CreatedBy,ModifiedBy) values 
('iPhone XS','1','1200','4','data seed','data seed'),
('iPhone 8','1','1000','3','data seed','data seed'),
('Samsung S9','1','1100','3','data seed','data seed'),
('HTC','1','1100','2','data seed','data seed'),
('iPad','2','1100','4','data seed','data seed'),
('samsung tablet','2','1100','3','data seed','data seed'),
('iPhone protectors','2','30','3','data seed','data seed'),
('headphone','3','30','3','data seed','data seed'),
('charger for iphone','3','30','4','data seed','data seed'),
('USB-c Charger ','3','30','3','data seed','data seed'),
('iWatch','4','400','4','data seed','data seed'),
(' Samsung watch','4','250','3','data seed','data seed')

