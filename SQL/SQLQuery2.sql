--1.Select all category names with their descriptions from the Categories table.
select CategoryName , Description from Categories;

--2.Select the contact name, customer id, and company name of all Customers in London
select contactName , CustomerID , CompanyName from Customers
where City like 'London';

--3.Marketing managers and sales representatives have asked you to select all available columns in the Suppliers tables that have a FAX number.
select * from Suppliers;

select * from Suppliers
where fax is not null;

--4.Select a list of customers id’s from the Orders table with required dates between Jan 1, 1997 and Jan 1, 1998 and with freight under 100 units. 
Select * from Orders

Select CustomerID from Orders
where RequiredDate Between '1997-01-01' AND '1998-01-01'
	And Freight<100;

--5.Select a list of company names and contact names of all the Owners from the Customer table from México D.F., Sweden and Germany. 
Select * from Customers

Select CompanyName , ContactName from Customers
where ContactTitle='Owner' And
	Country in ('México','Sweden','Germany');

--6.Count the number of discontinued products in the Products table.
Select * from Products

Select count(Discontinued) from Products
where Discontinued = 1;

--7.Select a list of category names and descriptions of all categories beginning with 'Co' from the Categories table.
Select * from Categories

Select CategoryName,Description from Categories
where CategoryName like 'Co%'

--8.Select all the company names, city, country and postal code from the Suppliers table with the word 'rue' in their address. The list should be ordered alphabetically by company name. 
Select * from Suppliers

Select CompanyName,City,Country,PostalCode from Suppliers
where Address like '%rue%'
Order by CompanyName

--9.Select the product id and the total quantities ordered for each product id in the Order Details table.
Select * from [Order Details]
SELECT * FROM PRODUCTS
Select ProductID, SUM(Quantity) as total_Quantity from [Order Details]
group by ProductID 

--10.Select the customer name and customer address of all customers with orders that shipped using Speedy Express. 
Select * from Customers
Select * from Orders

SELECT C.ContactName, C.Address , S.CompanyName FROM Customers AS C
INNER JOIN Orders AS O
ON C.CustomerID = O.CustomerID
INNER JOIN Shippers AS S
ON O.ShipVia = S.ShipperID

--11.Select a list of Suppliers containing company name, contact name, contact title and region description. 
Select * from Suppliers

Select CompanyName , ContactName, ContactTitle, region from Suppliers
WHERE COMPANYNAME IS NOT NULL
AND ContactName IS NOT NULL
AND ContactTitle IS NOT NULL
AND Region IS NOT NULL

--12.Select all product names from the Products table that are condiments. 
Select * from Products
select * from Categories

SELECT P.ProductName FROM Products AS P
INNER JOIN Categories AS C
ON C.CategoryID = P.CategoryID
where CategoryName like 'Condiments'

--13.Select a list of customer names who have no orders in the Orders table. 
Select * from Orders
Select * from Customers

SELECT c.[companyname]
FROM Customers c
LEFT JOIN Orders o ON c.[customerid] = o.CustomerId
WHERE o.OrderId IS NULL;


--14.Add a shipper named 'Amazon' to the Shippers table using SQL.
INSERT INTO Shippers(CompanyName)
VALUES ('AMAZON')

--For check--
--SELECT * FROM Shippers

--15.Change the company name from 'Amazon' to 'Amazon Prime Shipping' in the Shippers table using SQL. 
Update Shippers
Set CompanyName = 'Amazon Prime Shipping'
Where CompanyName = 'AMAZON'

--For check--
--SELECT * FROM Shippers

--16.Select a complete list of company names from the Shippers table. Include freight totals rounded to the nearest whole number for each shipper from the Orders table for those shippers with orders. 
Select CompanyName,Round(Sum(Orders.Freight),0) from Shippers
Inner join Orders
on Orders.ShipVia = Shippers.ShipperID
Group BY Shippers.CompanyName

--17.Select all employee first and last names from the Employees table by combining the 2 columns aliased as 'DisplayName'. The combined format should be 'LastName, FirstName'.
SELECT CONCAT(LastName , ',' , FirstName) AS DisplayName FROM Employees

--18.Add yourself to the Customers table with an order for 'Grandma's Boysenberry Spread'.
Select * from Products
Select * from Customers
Select * from Orders


--19.Remove yourself and your order from the database.


--20.Select a list of products from the Products table along with the total units in stock for each product. Give the computed column a name using the alias, 'TotalUnits'. Include only products with TotalUnits greater than 100.
Select * from Products

Select ProductName , UnitsInStock as TotalUnit from Products 
where UnitsInStock > 100