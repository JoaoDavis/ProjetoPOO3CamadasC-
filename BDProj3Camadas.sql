create database Projeto3CamadasPOO;

use Projeto3CamadasPOO;

create table Usuario (
	idUsuario int primary key auto_increment not null,
    usuario varchar(10) not null, 
    pass varchar(30) not null
);

create table Administrador (
	idAdmin int primary key auto_increment not null,
    UserAdmin varchar(10) not null,
    pass varchar(30) not null
);


create table Tenis (
	idTenis int primary key auto_increment not null,
    tamanho varchar(5) not null, 
    marca varchar(20) not null,
    cor varchar(25) not null,
    modelo varchar(30) not null
);

create table Fornecedor (
	idFornecedor int primary key auto_increment not null,
    nomeFornecedor varchar(80) not null,
    CNPJ char(18) not null,
    Telefone char(11) not null,
    Endereco varchar(100) not null
);

create table Venda (
	idVenda int primary key auto_increment not null,
    dataVenda date not null,
    nomeVend varchar(50) not null,
    precoVenda float not null
);

create table Vendedor (
	idVendedor int primary key auto_increment not null,
    nomeVendedor varchar(50) not null,
    CPF char(14) not null,
    Telefone char(11) not null,
    Endereco varchar(100) not null
);

select * from usuario;

