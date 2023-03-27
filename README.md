# example-Dapper-dotNet
Exemplo de persistência utilizando o ORM Dapper com .Net

<br>

* Script SQL Server:
<code>

CREATE DATABASE DemoDapper

USE DemoDapper

CREATE TABLE Pessoa(
	Id BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
	Nome VARCHAR(150) NOT NULL,
	Idade INT NOT NULL,
	DataRegistro DATETIME DEFAULT GETDATE()
)

</code>

