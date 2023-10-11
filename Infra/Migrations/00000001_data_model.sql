drop database if exists `sebo-cultural`;
create database if not exists `sebo-cultural` default character set utf8;

use `sebo-cultural`;

-- Cria a tabela para armazenamento dos produtos.
drop table if exists `produto`;
create table `produto`
(
    `idProduto` int unsigned not null auto_increment primary key,
    `Titulo` varchar(300) not null,
    `DataLancamento` date null,
    `ProdutoEstado` varchar(100) not null,
    `idCategoria` smallint unsigned not null,
    `idAutor` smallint unsigned not null,
    `idEditora` smallint unsigned not null,
    `ProdutoTipo` smallint unsigned not null,
    `CustoAquisicao` decimal not null,
    `ValorVenda` decimal not null,
    `DataAquisicao` date not null,
    `DataVenda` date not null
);

-- Cria a tabela para armazenamento dos autores da plataforma.
drop table if exists `autor`;
create table `autor`
(
    `idAutor` smallint unsigned not null auto_increment primary key,
    `Nome` varchar(100) not null,
    `DataNascimento` date not null,
    `Nacionalidade` varchar(30) not null
);

-- Cria a tabela para armazenamento dos autores da plataforma.
drop table if exists `editora`;
create table `editora`
(
    `idEditora` smallint unsigned not null auto_increment primary key,
    `Editora` varchar(100) not null
);


-- Cria a tabela para armazenamento dos autores da plataforma.
drop table if exists `categoria`;
create table `categoria`
(
    `idCategoria` smallint unsigned not null auto_increment primary key,
    `Categoria` varchar(100) not null,
    `CategoriaProdutoTipo` smallint not null
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