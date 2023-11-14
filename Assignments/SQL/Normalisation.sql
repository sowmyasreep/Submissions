
use Assignments

create table clientrental(clientno varchar(10),cname varchar(20),propertyno varchar(10),
paddress varchar(30),rentstart date,rentfinish date,rent bigint,ownerno varchar(10),oname varchar(20))

insert into clientrental(clientno,cname,propertyno,paddress,rentstart,rentfinish ,rent,ownerno,oname)
values('cr76','john kay','pg4','6 lawerence st.glasgow','1-jul-00','31-aug-01',350,'co40','tina murphy'),
      ('cr76','john kay','pg16','5 novar dr glasgow','1-sep-02','1-sep-03',450,'co93','tony shaw'),
	  ('cr56','aline stewart','pg4','6 lawerence st.glasgow','1-sep-99','10-jun-00',350,'co40','tina murphy'),
	  ('cr56','aline stewart','pg36','2 manor rd.glasgow','10-oct-00','1-dec-01',370,'co93','tony shaw'),
	   ('cr56','aline stewart','pg16','5 novar dr glasgow','1-nov-02','1-aug-03',450,'co93','tony shaw')
	   
select  * from clientrental


 --Table
create table client1(clientno varchar(10) primary key,cname varchar(20))

insert into client1(clientno,cname) values('cr76','john kay'),('cr56','aline stewart')

select * from client1



  --table
create table owner1(ownerno varchar(10)primary key,oname varchar(20))
 insert into owner1(ownerno,oname)
values ('co40','tina murphy'),('co93','tony shaw')
select * from owner1


--table
create table propertyowner1(propertyno varchar(10)primary key,paddress varchar(30),rent bigint,ownerno varchar(10))
insert into propertyowner1(propertyno,paddress,rent,ownerno) 
values('pg4','6 lawerence st.glasgow',350,'co40'),
('pg16','5 novar dr glasgow ',450,'co93'),
('pg36','2 manor rd.glasgow ',370,'co93')
select * from propertyowner1

 
--table
create table rental1(clientno varchar(10) foreign key references client1(clientno),propertyno varchar(10)
foreign key references propertyowner1(propertyno),rentstart date,rentfinish date)
insert into rental1(clientno,propertyno,rentstart,rentfinish )
values('cr76','pg4','2000-07-01','2001-08-31'),
      ('cr76','pg16','2002-09-01','2003-09-01'),
	  ('cr56','pg4','1999-09-01','2000-06-10'),
	  ('cr56','pg36','2000-10-10','2001-12-01'),							
	  ('cr56','pg16','2002-11-01','2003-08-01')
				  
select * from rental1

select c.clientno,c.cname,po.propertyno,po.rent,r.rentstart,r.rentfinish,o.oname,po.paddress
from Client1 c inner join rental1 r on c.clientno= r.clientno inner join propertyowner1 po on r.propertyno=po.propertyno
inner join owner1 o on po.ownerno = o.ownerno