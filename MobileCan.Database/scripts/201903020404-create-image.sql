create table Image(
Id int identity(1,1) Primary key,
ImageUrl nvarchar(400),
ProductId int FOREIGN KEY REFERENCES Product(ProductId)

)
insert into Image(ImageUrl, ProductId) values 
('/images/iphone8.jpg','2'),
('/images/iphonex.jpg','1'),
('/images/samsung-phone.jpg','3'),
('/images/htc.jpg','4'),
('/images/ipad.jpg','5'),
('/images/samsung-tablet.jpg','6'),
('/images/iphone-protector.jpg','7'),
('/images/headphone.jpg','8'),
('/images/samsung-watch.jpg','12')