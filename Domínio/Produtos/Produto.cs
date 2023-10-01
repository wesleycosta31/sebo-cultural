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

    /// <summary>ID da categoria do produto.</summary>
    public int? IDCategoria { get; set; }

    /// <summary>Quantidade de páginas do produto.</summary>
    public int? QtdPaginas { get; set; }

    /// <summary>Ano de lançamento do produto.</summary>
    public int? AnoLancamento { get; set; }

    /// <summary>ID do Autor do produto.</summary>
    public int IDAutor { get; set; }

    /// <summary>ID da Editora do produto.</summary>
    public int IDEditora { get; set; }

    /// <summary>Estado de consevação do produto.</summary>
    public ProdutoEstado ProdutoEstado { get; set; }

    /// <summary>Tipo do produto.</summary>
    public ProdutoTipo ProdutoTipo { get; set; }

    /// <summary>Custo do produto na aquisição.</summary>
    public decimal CustoAquisicao { get; set; }

    /// <summary>Valor do produto para venda.</summary>
    public decimal ValorVenda { get; set; }

    /// <summary>Data da aquisição do produto.</summary>
    public DateTime DataAquisicao { get; set; }

    /// <summary>Data da venda do produto.</summary>
    public DateTime DataVenda { get; set; }

    /// <summary>Construtor com parâmetros.</summary>
    public Produto(int id, string titulo, Categoria categoria, int? paginas, int anoLancamento,
     int iDAutor, Autor autor, int iDEditora, Editora editora, ProdutoEstado produtoEstado, ProdutoTipo produtoTipo,
     decimal custoAquisicao, decimal valorVenda, DateTime dataAquisicao, DateTime dataVenda)
    {
        ID = id;
        Titulo = titulo;
        QtdPaginas = paginas;
        AnoLancamento = anoLancamento;
        IDAutor = iDAutor;
        IDEditora = iDEditora;
        ProdutoEstado = produtoEstado;
        ProdutoTipo = produtoTipo;
        CustoAquisicao = custoAquisicao;
        ValorVenda = valorVenda;
        DataAquisicao = dataAquisicao;
        DataVenda = dataVenda;
    }

    /// <summary>Construtor utilizado no processo de cadastro de um livro.</summary>
    /// <param name="dto">DTO do processo de cadastro de livro.</param>
    public Produto(CadastraLivroDTO dto)
    {
        Titulo = dto.Titulo;
        QtdPaginas = dto.Paginas;
        AnoLancamento = dto.AnoLancamento;
        ProdutoEstado = dto.LivroEstado;
        ProdutoTipo = dto.ProdutoTipo;
        CustoAquisicao = dto.CustoAquisicao;
        ValorVenda = dto.ValorVenda;
        DataAquisicao = dto.DataAquisicao;
        DataVenda = dto.DataVenda;
    }

    /// <summary>Construtor utilizado no processo de cadastro de um album de música.</summary>
    /// <param name="dto">DTO do processo de cadastro de livro.</param>
    public Produto(CadastraAlbumMusicalDTO dto)
    {
        Titulo = dto.Titulo;
        AnoLancamento = dto.AnoLancamento;
        ProdutoEstado = dto.AlbumEstado;
        ProdutoTipo = dto.ProdutoTipo;
        CustoAquisicao = dto.CustoAquisicao;
        ValorVenda = dto.ValorVenda;
        DataAquisicao = dto.DataAquisicao;
        DataVenda = dto.DataVenda;
    }

}