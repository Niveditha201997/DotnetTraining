create Database LibraryManagementEntity;

use LibraryManagementEntity;

 create table Admin (AdminId Int primary key Identity,AdminEmail varchar(100) ,AdminName varchar(100),AdminPassword varchar(100));

 create table User_ (UserId Int primary key,UserEmail varchar(100),UserName varchar(100),Userpassword varchar(100) );

 create table Book (BookId Int primary key,BookAuthor varchar(100),BookCopies Int,BookName varchar(100));

 create table RequestedBook (BookId Int,BookName varchar(100),DateRequested date,foreign key(UserId) references User_(UserId) ON DELETE CASCADE)
 
	insert into Book values (1,'Smith',3,'power');