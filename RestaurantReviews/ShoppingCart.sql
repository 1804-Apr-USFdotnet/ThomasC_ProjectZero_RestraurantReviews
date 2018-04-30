create table Products (
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] 	[nvarchar](25) null,
	[Price] [int] null
);

create table Orders(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	ProductID int FOREIGN KEY (ProductID) REFERENCES Products(ID),
	CustomerID int FOREIGN KEY (CustomerID) REFERENCES Customers(ID),
);

create table Customers(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) null,
	[LastName] [nvarchar](50) null,
	[CardNumber] [numeric]
);

--Add at least 3 records into each table
insert into Products([ID], [Name], [Price]) values (1, 'Camera', 100);
insert into Products([ID], [Name], [Price]) values (2, 'iPhone', 200); -- Add product iphone priced at $200
insert into Products([ID], [Name], [Price]) values (3, 'Laptop', 500);

insert into Customers([ID], [FirstName], [LastName], [CardNumber]) values (1, 'Tina', 'Smith', 1234567890);
insert into Customers([ID], [FirstName], [LastName], [CardNumber]) values (2, 'John', 'Smith', 2345678901);
insert into Customers([ID], [FirstName], [LastName], [CardNumber]) values (3, 'James', 'Smith', 3456789012);

--Report all orders by Tina Smith
Select * from Orders o join Customers c on c.ID = o.CustomerID where CustomerID = 1;

--