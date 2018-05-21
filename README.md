# AdventureWorksEFCodeFirst
EF 6 CodeFirst for AdventureWorks2017 (SqlServer) database using .net 4.5

Download and Install Microsoft SQL Server Management Studio 17:<br/>
https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017

Download AdventureWorks2017 database:<br/>
https://github.com/Microsoft/sql-server-samples/releases/download/adventureworks/AdventureWorks2017.bak

- Import AdventureWorks2017.bak into your database
- Add EntityFramework 6.2.0 reference into your project (Install-Package EntityFramework -version 6.2.0)

Namespaces:
 * AdventureWorks (Root)
    - AdventureWorksContext (Model context class)
 * AdventureWorks.Entities
    - .HumanResources (HumanResources Scheme Entities)
    - .People (Person Scheme Entities)
    - .Production (Production Scheme Entities)
    - .Purchasing (Purchasing Scheme Entities)
    - .Sales (Sales Scheme Entities)
