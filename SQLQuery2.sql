--select
select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers 

select * from Customers where City='Berlin'


--case insensitive kucuk buyuk harf duyarlılığı yok select=SelEcT gibi  
select * from Products where CategoryID='1' or CategoryID='3'

select * from Products where CategoryID='1' and UnitPrice>=10

select * from Products order by UnitPrice asc ----ascending artan ///// order by sıralama metodu

select * from Products where  CategoryID ='1' order by UnitPrice desc ----descending düşen

select Count(*) from Products --Kaçtane satır var

select Count(*) from Products where CategoryID ='2'

select Count(*) Adet from Products where CategoryID =2 -- katagoriId si 2 olanları say

select CategoryID,count(*) Adet from Products group by  CategoryID  -- catagoriId'lerden hangisinden kaçtaane var

select CategoryID,count(*) Adet from Products group by  CategoryID having count(*)<10 -- katagoriId'lerdekilerin katagorilerdekilerin 
                                                                                      --10 teneden az olanları getir


select CategoryID,count(*)  from Products where UnitPrice>20 group by  CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID=Categories.CategoryID                 ----2 Tabloyu birleştirme join
where Products.UnitPrice >10                                                                     ---- 2 tabloda eşleşenleri getirir.
--DTO Data Transformation Object

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID  ---solda olup sağda olmayanları getirir

select * from Products p right join [Order Details] od on p.ProductID = od.ProductID  ---- sağda olup solda olmyanları getirir

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null



select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID=od.OrderID


Select p.ProductName 'Ürünün Adı', sum(od.UnitPrice*od.Quantity) 'Kazanılan Toplam Miktar'
from Products p 
inner join [Order Details] od on p.ProductID = od.ProductID
inner join Orders o on od.OrderID = o.OrderID group by p.ProductName 

Select p.ProductName 'Ürün Adı',SUM(od.UnitPrice*od.Quantity) 'Kazanılan Toplam Miktar'
from Products p,[Order Details] od,Orders o where p.ProductID= od.ProductID and o.OrderID=od.OrderID
group by p.ProductName
