CREATE DATABASE ExampleDb;
GO

USE ExampleDb;
GO

CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100)
);
GO

