using sebo_cultural.DTOS;
using sebo_cultural.Enums;

namespace sebo_cultural.Domínio;

/// <summary>Classe que representa um produto da plataforma.</summary>
public class Produto
{
    /// <summary>Código de identificação do produto.</summary>
    public int ID { get; set; }

    /// <summary>Título do livro.</summary>
    public string Titulo { get; set; } = null!;

    /// <summary>Categoria do produto.</summary>
    public Categoria? Categoria { get; set; } = null!;

    /// <summary>Quantidade de páginas do livro.</summary>
    public int? QtdPaginas { get; set; }

    /// <summary>Ano de lançamento do livro.</summary>
    public int? AnoLancamento { get; set; }

    /// <summary>ID do Autor do livro.</summary>
    public int? IDAutor { get; set; }

    /// <summary>Autor do livro.</summary>
    public Autor? Autor { get; set; }

    /// <summary>ID da Editora do livro.</summary>
    public int? IDEditora { get; set; }

    /// <summary>Editora do livro.</summary>
    public Editora? Editora { get; set; }

    /// <summary>Estado de consevação do produto.</summary>
    public ProdutoEstado ProdutoEstado { get; set; }

    /// <summary>Tipo do produto.</summary>
    public ProdutoTipo ProdutoTipo { get; set; }

    /// <summary>Construtor com parâmetros.</summary>
    public Produto(int id, string titulo, Categoria categoria, int? paginas, int anoLancamento,
     int iDAutor, Autor? autor, int iDEditora, Editora editora, ProdutoEstado produtoEstado, ProdutoTipo produtoTipo)
    {
        ID = id;
        Titulo = titulo;
        Categoria = categoria;
        QtdPaginas = paginas;
        AnoLancamento = anoLancamento;
        IDAutor = iDAutor;
        Autor = autor;
        IDEditora = iDEditora;
        Editora = editora;
        ProdutoEstado = produtoEstado;
        ProdutoTipo = produtoTipo;
    }

    /// <summary>Construtor utilizado no processo de cadastro de um livro.</summary>
    /// <param name="dto">DTO do processo de cadastro de livro.</param>
    public Produto(CadastraLivroDTO dto)
    {
        Titulo = dto.Titulo;
        Categoria = dto.Tema;
        QtdPaginas = dto.Paginas;
        AnoLancamento = dto.AnoLancamento;
        Autor = dto.Autor;
        Editora = dto.Editora;
        ProdutoEstado = dto.LivroEstado;
        ProdutoTipo = ProdutoTipo.Livro;
    }

    /// <summary>Construtor utilizado no processo de cadastro de um album de música.</summary>
    /// <param name="dto">DTO do processo de cadastro de livro.</param>
    public Produto(CadastraAlbumMusicalDTO dto)
    {
        Titulo = dto.Titulo;
        Categoria = dto.Tema;
        AnoLancamento = dto.AnoLancamento;
        Autor = dto.Autor;
        Editora = dto.Editora;
        ProdutoEstado = dto.AlbumEstado;
        ProdutoTipo = ProdutoTipo;
    }

}