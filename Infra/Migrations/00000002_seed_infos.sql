use `sebo-cultural`;

-- Adiciona uma autor.
    insert into `autor`(`Nome`, `DataNascimento`, `Nacionalidade`)
values('Lucas Silveira', '1983-01-12', 'Brasileiro');

-- Adiciona uma editora.
    insert into `editora`(`Editora`)
values
    ('Nublense');

-- Adiciona categorias para livros.
    insert into `categoria`(`Categoria`, `CategoriaProdutoTipo`)
values
    ('Suspense', '0'),
    ('Romance', '0'),
    ('Ficção Científica', '0'),
    ('Fantasia', '0'),
    ('Mistério', '0'),
    ('Não Ficção', '0'),
    ('Drama', '0'),
    ('Aventura', '0'),
    ('História', '0'),
    ('Poesia', '0'),
    ('Conto', '0'),
    ('Autoajuda', '0'),
    ('Biografia', '0'),
    ('Clássico', '0'),
    ('Comédia', '0'),
    ('Distopia', '0'),
    ('Erotismo', '0'),
    ('Humor', '0'),
    ('LGBTQ+', '0'),
    ('Mitologia', '0'),
    ('Policial', '0'),
    ('Religião', '0'),
    ('Saúde e Bem-Estar', '0'),
    ('Terror', '0'),
    ('Viagem', '0'),
    ('Ficção Histórica', '0'),
    ('Literatura Brasileira', '0'),
    ('Literatura Estrangeira', '0');

-- Adiciona categorias para albuns.
    insert into `categoria` (`Categoria`, `CategoriaProdutoTipo`)
values
    ('Rock', '1'),
    ('Pop', '1'),
    ('Hip-Hop', '1'),
    ('Jazz', '1'),
    ('Blues', '1'),
    ('R&B', '1'),
    ('Eletrônica', '1'),
    ('Country', '1'),
    ('Reggae', '1'),
    ('Clássica', '1'),
    ('Funk/Soul', '1'),
    ('Indie', '1'),
    ('Samba', '1'),
    ('Forró', '1'),
    ('Sertanejo', '1'),
    ('Bossa Nova', '1'),
    ('Música Latina', '1'),
    ('Música Brasileira', '1'),
    ('Trilha Sonora', '1'),
    ('Pagode', '1'),
    ('Axé', '1'),
    ('MPB', '1'),
    ('Funk Carioca', '1'),
    ('Frevo', '1'),
    ('Maracatu', '1'),
    ('Tropicalia', '1');

-- Adiciona categorias histórias em quadrinhos.
    insert into `categoria` (`Categoria`, `CategoriaProdutoTipo`)
values
    ('Super-Heróis', '2'),
    ('Mangá', '2'),
    ('Ação e Aventura', '2'),
    ('Fantasia', '2'),
    ('Ficção Científica', '2'),
    ('Crime e Mistério', '2'),
    ('Histórico', '2'),
    ('Romance', '2'),
    ('Comédia', '2'),
    ('Terror', '2'),
    ('Drama', '2'),
    ('Infantil', '2'),
    ('Gibi', '2'),
    ('Graphic Novels', '2');