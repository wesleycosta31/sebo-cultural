create database if not exists `sebo-cultural`;` default character set utf8;

use `sebo-cultural`;

-- Cria a tabela para armazenamento dos usuários.
drop table if exists `user`;
create table `user`
(
    `idUser` int unsigned not null auto_increment primary key,
    `Name` varchar(100) not null,
    `Email` varchar(100) not null,
    `Cellphone` varchar (200) null,
    `State` tinyint unsigned not null,
    index `idx_user_name` (`Name`, `idUser`, `Email`, `Cellphone`, `State`),
    index `idx_user_email` (`Email`, `idUser`, `Name`, `Cellphone`, `State`)
);

-- Cria a tabela para armazenamento dos perfis dos usuários.
drop table if exists `user_role`;
create table `user_role`
(
    `idUser` int unsigned not null,
    `Role` tinyint unsigned not null,
    constraint primary key (`idUser`, `Role`),
    constraint `fk_user_role_user` foreign key (`idUser`)
        references `user`(`idUser`)
);

-- Cria a tabela para armazenamento dos passaportes dos usuários.
drop table if exists `passport`;
create table `passport`
(
    `idUser` int unsigned not null,
    `Type` tinyint unsigned not null,
    `Password` varchar(200),
    `Secret` varchar(200),
    `idExternal` varchar(200),
    `Attempts` tinyint unsigned not null,
    `State` tinyint unsigned not null,
    constraint primary key (`idUser`, `Type`),
    constraint `fk_passport_system_user` foreign key (`idUser`)
        references `user`(`idUser`)
);

-- Cria a tabela para armazenamento dos tokens de acesso.
drop table if exists `access_token`;
create table `access_token`
(
    `idAccessToken` int unsigned not null auto_increment primary key,
    `idUser` int unsigned not null,
    `JWTToken` varchar(2048) null,
    `RefreshToken` varchar(2048) null,
    `IP` varchar(20) not null,
    `Refreshed` boolean not null,
    `CreatedAt` datetime not null,
    `Expires` datetime not null,
    `RefreshedAt` datetime null,
	`Canceled` boolean not null,
    constraint `fk_access_token_user` foreign key (`idUser`)
        references `user`(`idUser`),
    index `idx_access_token_idUser` (`idUser`, `idAccessToken`)
);

-- Cria a tabela para armazenamento dos códigos de validação.
drop table if exists `validation_code`;
create table `validation_code`
(
    `idCode` int unsigned not null auto_increment primary key,
    `idUser` int unsigned not null,
    `DestinationType` tinyint not null,
    `Destination` varchar(200) not null,
    `Code` varchar(10) not null,
    `IP` varchar (20),
    `Used` boolean not null,
    `RequestedDate` datetime not null,
    `UsedDate` datetime null,
    `ExpirationDate` datetime not null,
    `Fails` int not null,
    constraint `uq_validation_code` unique key (`idUser`, `Code`),
    constraint `fk_validation_code_user` foreign key (`idUser`)
        references `user`(`idUser`),
    index `idx_validation_code_user` (`idUser`, `idCode`, `DestinationType`,
        `Destination`, `Code`, `IP`, `Used`, `RequestedDate`, `UsedDate`, `ExpirationDate`, `Fails`)
);

-- Cria a tabela para armazenamento dos recursos.
drop table if exists `resource`;
create table `resource`
(
	`Type` tinyint unsigned not null,
    `idResource` smallint unsigned not null,
    `ParentResourceType` tinyint unsigned,
    `idParentResource` smallint unsigned,
    `Name` varchar(100) not null,
	constraint primary key (`Type`, `idResource`),
    constraint `fk_resource_resource` foreign key (`ParentResourceType`, `idParentResource`)
        references `resource`(`Type`, `idResource`),
    index `idx_resource_parent` (`idParentResource`, `idResource`, `Type`, `Name`)
);

-- Cria a tabela para armazenamento das permissões.
drop table if exists permission;
create table permission
(
    `idPermission` bigint unsigned not null auto_increment primary key,
    `ResourceType` tinyint unsigned not null,
	`idResource` smallint unsigned not null,
    `idUser` int unsigned not null,
    `Level` tinyint unsigned not null,
    `State` tinyint unsigned not null,
    constraint `fk_permission_resource` foreign key (`ResourceType`, `idResource`)
        references `resource`(`Type`, `idResource`),
    constraint `fk_permission_user` foreign key (`idUser`)
        references `user`(`idUser`),
    index `idx_permission_resource` (`ResourceType`, `idResource`, `idPermission`, `idUser`, `Level`, `State`),
    index `idx_permission_user` (`idUser`, `idPermission`, `ResourceType`, `idResource`, `Level`, `State`)
);