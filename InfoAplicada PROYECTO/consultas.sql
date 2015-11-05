--CATEGORIAS--
select ProductCategoryID, Name from ProductCategory order by ProductCategoryID;

--SUBCATEGORIAS--
select  psc.Name from ProductSubCategory psc inner join ProductCategory pc on pc.ProductCategoryID = psc.ProductCategoryID and psc.ProductCategoryID= (select ProductCategoryID from ProductCategory where Name = 'Bike') order by ProductSubCategoryID; 

--CLIENTES POR SUBCATEGORIAS--
select i.CustomerID, i.FirstName, i.LastName, ps.Name as subCategoria, COUNT(*) as Cantidad from Individual i
inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID inner join SalesOrderDetail sod
on sod.SalesOrderID = soh.SalesOrderID
inner join Product p on p.ProductID = sod.ProductID
inner join ProductSubCategory ps on ps.ProductSubCategoryID = (select ProductSubCategoryID from ProductSubCategory where name = 'Bike')  
group by i.CustomerID, i.FirstName, i.LastName, ps.Name order by Cantidad desc;

--CLIENTES POR CATEGORIAS--
select i.CustomerID, i.FirstName, i.LastName,  count(*) AS Cantidad from Individual i
inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID inner join SalesOrderDetail sod
on sod.SalesOrderID = soh.SalesOrderID
inner join Product p on p.ProductID = sod.ProductID
inner join ProductSubCategory ps on ps.ProductSubCategoryID = p.ProductSubCategoryID
inner join ProductCategory pc on pc.ProductCategoryID = ps.ProductCategoryID and 
pc.ProductCategoryID = (select ProductCategoryID from ProductCategory where Name = 'Bike') group by i.CustomerID, i.FirstName, i.LastName, pc.Name order by Cantidad desc;

--CLIENTES
select i.CustomerID, i.FirstName, i.LastName from Individual i
inner join SalesOrderHeader soh on soh.CustomerID = i.CustomerID group by i.CustomerID, i.FirstName, i.LastName

--cedula

select i.CustomerID, i.FirstName, i.LastName from Individual i
inner join SalesOrderHeader soh on i.CustomerID like '%20%' and soh.CustomerID = i.CustomerID group by i.CustomerID, i.FirstName, i.LastName order by i.CustomerID 


--region

select TerritoryID, name from SalesTerritory;

select i.CustomerID, i.FirstName, i.LastName, c.TerritoryID from Individual i
inner join Customer c on c.CustomerID = i.CustomerID
group by i.customerID, i.FirstName, i.LastName, c.TerritoryID

select * from Customer


--VIP

select i.CustomerID, i.FirstName, i.LastName, SUM(soh.totaldue) as totalCompras from Individual i
inner join SalesOrderHeader soh on i.CustomerID=soh.CustomerID
group by i.CustomerID, i.FirstName, i.LastName 
HAVING SUM(soh.totaldue) > (select avg(totaldue) from SalesOrderHeader)
order by totalCompras desc;