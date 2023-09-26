use `sebo-cultural`;

-- Adiciona uma usuário.
insert into `user`(`Name`, `Email`, `Cellphone`, `State`)
values('Relier', 'contato@relier.com.br', '(19) 99304-8584', 1);

-- Adiciona o perfil de Administrador ao usuário cadastrado.
insert into user_role(`idUser`, `Role`)
values(1, 0);

-- Adiciona um passaporte de acesso para o usuário cadastrado.
insert into passport(`idUser`, `Password`, `Secret`, `Type`, `Attempts`, `State`)
values(1, 'ObYFTIxuzaN43cV6tR/OA9zdSEAhZfYLnrdpaRXfogs=', 'N/x4KJQ5we0uaQ==', 0, 0, 1);