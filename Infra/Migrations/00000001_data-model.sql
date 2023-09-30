drop database if exists `sebo-cultural`;
create database if not exists `sebo-cultural` default character set utf8;

use `sebo-cultural`;

-- Cria a tabela para armazenamento dos produtos.
drop table if exists `produto`;
create table `produto`
(
    `idProduto` int unsigned not null auto_increment primary key,
    `Titulo` varchar(300) not null,
    `idCategoria` int unsigned not null,
    `Categoria` varchar(100) null,
    `ProdutoTipo` varchar(100) not null,
    `QtdPaginas` varchar (200) null,
    `AnoLancamento` int unsigned null,
    `idAutor` int unsigned not null,
    `Autor` varchar(100) not null,
    `idEditora` int unsigned not null,
    `Editora` varchar(100) not null,
    `ProdutoEstado` varchar(100) not null,
    `CustoAquisicao` decimal not null,
    `ValorVenda` decimal not null,
    `DataAquisicao` datetime not null,
    `DataVenda` datetime not null
);

-- Cria a tabela para armazenamento dos autores da plataforma.
drop table if exists `autor`;
create table `autor`
(
    `idAutor` int unsigned not null auto_increment primary key,
    `Nome` varchar(100) not null,
    `DataNascimento` datetime null,
    `Nacionalidade` varchar(30) not null
);

-- Cria a tabela para armazenamento dos autores da plataforma.
drop table if exists `editora`;
create table `editora`
(
    `idEditora` int unsigned not null auto_increment primary key,
    `Editora` varchar(100) not null
);


-- Cria a tabela para armazenamento dos autores da plataforma.
drop table if exists `categoria`;
create table `categoria`
(
    `idCategoria` int unsigned not null auto_increment primary key,
    `Categoria` varchar(100) not null
);

alter table `produto`
add constraint `fk_produto_autor` foreign key (`idAutor`)
    references `autor`(`idAutor`);

alter table `produto`
add constraint `fk_produto_editora` foreign key (`idEditora`)
    references `editora`(`idEditora`);

alter table `produto`    
add constraint `fk_produto_categoria` foreign key (`idCategoria`)
    references `categoria`(`idCategoria`);