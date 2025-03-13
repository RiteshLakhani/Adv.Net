--26.Select the customer name and the product name such that the quantity of this product bought by the customer in a single order is more than 5 times the average quantity of this product bought in a single order among all clients.4
Select * from Customers
Select * from Products
Select * from Orders
Select * from [Order Details]


SELECT c.CompanyName AS CustomerName, p.ProductName FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
WHERE 
    od.Quantity > 5 * (
        SELECT 
            AVG(od2.Quantity)
        FROM 
            [Order Details] od2
        WHERE 
            od2.ProductID = od.ProductID
    );


--25.Select the names of employees who sell the products of more than 7 suppliers. 
Select * from Employees
Select * from Suppliers
Select * from Products
Select * from Orders

SELECT e.FirstName FROM Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
JOIN Suppliers s ON p.SupplierID = s.SupplierID
GROUP BY e.EmployeeID, e.FirstName
HAVING COUNT(DISTINCT s.SupplierID) > 7;


--24.Select the identifier, name, and total sales of employees, ordered by the employee identifier for employees who have sold more than 70 different products.
Select * from Employees
Select * from Orders
select * from Products
select * from [Order Details]

SELECT e.EmployeeID,e.FirstName AS EmployeeName,SUM(od.Quantity * od.UnitPrice) AS TotalSales FROM Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY e.EmployeeID, e.FirstName
HAVING COUNT(DISTINCT od.ProductID) > 70
ORDER BY e.EmployeeID;


--23.Select the identifier, name, and total sales of employees, ordered by the employee identifier. 
SELECT e.EmployeeID,e.FirstName AS EmployeeName,SUM(od.Quantity * od.UnitPrice) AS TotalSales FROM Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY e.EmployeeID, e.FirstName
ORDER BY e.EmployeeID;

--22.For each employee give the identifier, name, and the number of distinct products sold, ordered by the employee identifier. 
Select e.EmployeeID,e.FirstName as EmployeeName , Count(Distinct od.ProductId) as DistinctProductSold from Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN [Order Details] od ON o.OrderID = od.OrderID
Group By e.EmployeeID,e.FirstName
Order By e.EmployeeID 

--21.Select the identifier, name, and number of orders of employees, ordered by the employee identifier.
Select * from Orders
Select * from [Order Details] 
select * from Employees

SELECT e.EmployeeID,e.FirstName AS EmployeeName,COUNT(o.OrderID) AS NumberOfOrders FROM Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
ORDER BY e.EmployeeID;



--20.Select the identifier and the name of the companies that provide more than 3 products.
select * from Products
select * from Suppliers

SELECT s.SupplierID,s.CompanyName FROM Suppliers s
JOIN Products p ON s.SupplierID = p.SupplierID
GROUP BY s.SupplierID, s.CompanyName
HAVING COUNT(p.ProductID) > 3
ORDER BY s.SupplierID;


--19.Given the name of the categories and the average price of products in each category.  
select * from Categories
select * from Products

SELECT c.CategoryName,AVG(p.UnitPrice) AS AveragePrice FROM Categories c
JOIN Products p ON c.CategoryID = p.CategoryID
GROUP BY c.CategoryName
ORDER BY c.CategoryName;

--18.Select the average price of products by category. 
SELECT c.CategoryName,AVG(p.UnitPrice) AS AveragePrice FROM Categories c
JOIN Products p ON c.CategoryID = p.CategoryID
GROUP BY c.CategoryName
ORDER BY c.CategoryName;

--17.Select the name of customers who bought exactly the same products as the customer whose identifier is ‘LAZYK’  

--16.Select the name of customers who bought all products purchased by the customer whose identifier is ‘LAZYK’  

--15.Select the name of the products sold by all employees. 
Select * from Employees
select * from Products
select * from [Order Details]
select * from Orders

SELECT ProductName FROM Products
JOIN [Order Details]  ON [Order Details].ProductID = Products.ProductID
JOIN Orders  ON [Order Details].OrderID = Orders.OrderID
JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
GROUP BY Products.ProductID, Products.ProductName
HAVING COUNT(DISTINCT Employees.EmployeeID) = (SELECT COUNT(*) FROM Employees);

