create database normalization 
use normalization

create table ClientRental
(
  clientno varchar(30),
  propertyno varchar(20),
  cname varchar(30),
  paddress varchar(30),
  rentstart date,
  rentfinish date,
  rent int,
  ownerno varchar(30),
  oname varchar(30)
)

insert into Clientrental values
('CR76','PG4','John kay','6 Lawrence st,Glasgow','1-jun-00','31-aug-01',350,'CO40','Tina Murphy'),
('CR76','PG16','John kay','5 Novar Dr,Glasgow','1-sep-02','1-sep-02',450,'CO93','Tony shaw'),
('CR56','PG4','Aline Stewart','6 Lawrence st,Glasgow','1-sep-99','10-jun-00',350,'CO40','Tina Murphy'),
('CR56','PG4','Aline Stewart','2 Manor Rd,Glasgow','10-oct-00','1-dec-01',370,'CO93','Tony shaw'),
('CR56','PG4','Aline Stewart','5 Novar Dr,Glasgow','1-nov-02','1-aug-03',450,'CO93','Tony shaw')

select * from ClientRental

create table client
(
   clientno varchar(30) primary key ,
   cname varchar(20)
)

insert into client values
('CR76','John kay'),
('CR56','Aline Stewart')

select * from client

/*create table propertyrental
(
  clientno varchar(30),
  propertyno varchar(20),
  paddress varchar(30),
  rentstart date,
  rentfinish date,
  rent int,
  ownerno varchar(30),
  oname varchar(30)
)
 
insert into PropertyRental values
('CR76','PG4','6 Lawrence st,Glasgow','1-jun-00','31-aug-01',350,'CO40','Tina Murphy'),
('CR76','PG16','5 Novar Dr,Glasgow','1-sep-02','1-sep-02',450,'CO93','Tony shaw'),
('CR56','PG4','6 Lawrence st,Glasgow','1-sep-99','10-jun-00',350,'CO40','Tina Murphy'),
('CR56','PG36','2 Manor Rd,Glasgow','10-oct-00','1-dec-01',370,'CO93','Tony shaw'),
('CR56','PG4','5 Novar Dr,Glasgow','1-nov-02','1-aug-03',450,'CO93','Tony shaw')

select * from PropertyRental*/

create table owners
(
  ownerno varchar(30) primary key,
  oname varchar(20)
)

insert into owners values 
('CO40','Tina Murphy'),
('CO93','Tony shaw')
  
select * from owners

create table propertyOwner
(
   Propertno varchar(30) primary key,
   paddress varchar(30),
   Rent int ,
   ownerno varchar(30) foreign key references Owners(ownerno),
   oname varchar(30)
)

insert into propertyOwner values
('PG4','6 Lawrence st,Glasgow',350,'CO40','Tina Murphy'),
('PG16','5 Novar Dr,Glasgow',450,'CO93','Tony shaw'),
('PG36','2 Manor Rd,Glasgow',370,'CO93','Tony shaw')

select * from propertyowner

create table rental
(
   clientno varchar(30) foreign key references client(clientno),
   propertyno varchar(30) foreign key references Propertyowner(propertno),
   rentstart date,
   rentfinish date
)

insert into rental values 
('CR76','PG4','1-jun-00','31-aug-01'),
('CR76','PG16','1-sep-02','1-sep-03'),
('CR56','PG4','1-sep-99','10-jun-00'),
('CR56','PG36','10-oct-00','1-dec-01'),
('CR56','PG4','1-nov-02','1-aug-03')

select * from ClientRental
select * from client
select * from owners
select * from propertyowner
select * from rental



/*select c.clientno,c.cname,po.propertno,po.rent,r.rentstart,r.rentfinish,o.oname
		  from clientNo c inner join rental r on c.clientno=r.clientno inner join propertyowner po on r.propertyno=po.propertno inner join 
		  owners o on o.ownerno=po.ownerno*/