--CATEGORIAS--
select ProductCategoryID, Name from ProductCategory order by ProductCategoryID;

--SUBCATEGORIAS--
select ProductSubCategoryID, Name from ProductSubCategory order by ProductSubCategoryID; 

--CLIENTES POR SUBCATEGORIAS--
select i.CustomerID, i.FirstName, i.LastName, ps.Name as subCategoria, COUNT(*) as Cantidad from Individual i
inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID inner join SalesOrderDetail sod
on sod.SalesOrderID = soh.SalesOrderID
inner join Product p on p.ProductID = sod.ProductID
inner join ProductSubCategory ps on ps.ProductSubCategoryID = 2  
group by i.CustomerID, i.FirstName, i.LastName, ps.Name order by Cantidad desc;

--CLIENTES POR CATEGORIAS--
select i.CustomerID, i.FirstName, i.LastName, pc.Name as Categoria, count(*) AS Cantidad from Individual i
inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID inner join SalesOrderDetail sod
on sod.SalesOrderID = soh.SalesOrderID
inner join Product p on p.ProductID = sod.ProductID
inner join ProductSubCategory ps on ps.ProductSubCategoryID = p.ProductSubCategoryID
inner join ProductCategory pc on pc.ProductCategoryID = ps.ProductCategoryID and 
pc.ProductCategoryID = 1 group by i.CustomerID, i.FirstName, i.LastName, pc.Name order by Cantidad desc;

--CLIENTES
select i.CustomerID, i.FirstName, i.LastName from Individual i
inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID group by i.CustomerID, i.FirstName, i.LastName

--cedula

SELECT * FROM Customer WHERE CustomerID LIKE '%20%';

--region



--VIP

select sum(totaldue) as totalCompras
from SalesOrderHeader
group by CustomerID 
HAVING SUM(totaldue) > (select avg(totaldue) from SalesOrderHeader)
order by totalCompras desc;