--SUBCATEGORIAS--
select i.CustomerID, i.FirstName, i.LastName, ps.Name, COUNT(*) as Cantidad from Individual i
inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID inner join SalesOrderDetail sod
on sod.SalesOrderID = soh.SalesOrderID
inner join Product p on p.ProductID = sod.ProductID
inner join ProductSubCategory ps on ps.ProductSubCategoryID = 2  
group by i.CustomerID, i.FirstName, i.LastName, ps.Name;

--CATEGORIAS--
select i.CustomerID, i.FirstName, i.LastName, count(*) AS Cantidad from Individual i
inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID inner join SalesOrderDetail sod
on sod.SalesOrderID = soh.SalesOrderID
inner join Product p on p.ProductID = sod.ProductID
inner join ProductSubCategory ps on ps.ProductSubCategoryID = p.ProductSubCategoryID
inner join ProductCategory pc on pc.ProductCategoryID = ps.ProductCategoryID and 
pc.ProductCategoryID = 1 group by i.CustomerID, i.FirstName, i.LastName;

