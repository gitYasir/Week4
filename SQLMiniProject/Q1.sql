-- 1.1
SELECT CustomerID, CompanyName, Address, City, PostalCode, Country
FROM Customers
where city in('Paris','London');

-- 1.2
SELECT ProductName, QuantityPerUnit
FROM Products
WHERE QuantityPerUnit LIKE '%bottles%';

-- 1.3
SELECT ProductName, QuantityPerUnit, s.CompanyName, s.Country
FROM Products
INNER JOIN Suppliers s
    ON s.SupplierID = Products.SupplierID
WHERE QuantityPerUnit LIKE '%bottles%';

--1.4
SELECT cn.CategoryName AS "Category Name", COUNT(p.ProductID) AS "No of Products"
FROM Categories cn
INNER JOIN Products p
    ON cn.CategoryID = p.CategoryID
GROUP BY cn.CategoryName
ORDER BY COUNT(p.ProductID) DESC;
-- 1.5
SELECT titleofcourtesy + ' ' + firstname + ' ' + lastname AS "Full Name", city AS "City"
FROM Employees;

-- 1.6
SELECT COUNT(freight) AS "No of Orders >100 from US or UK"
FROM orders
WHERE ShipCountry in('UK','USA') AND Freight > 100;

-- 1.7
SELECT od.OrderID AS "Order ID",  
       FORMAT((od.UnitPrice * od.Quantity) * od.Discount,'C') AS "Discount Amount"
    FROM [Order Details] od
    WHERE (UnitPrice * Quantity) * Discount = (
        SELECT MAX((UnitPrice * Quantity) * Discount)
        FROM [Order Details]
        )


-- 1.8
SELECT e.FirstName + ' ' + e.LastName AS "Employee Name", ep.FirstName + ' ' + ep.LastName AS "Reports To"
FROM Employees e
INNER JOIN Employees ep
ON e.ReportsTo = ep.EmployeeID
ORDER BY 2, 1;