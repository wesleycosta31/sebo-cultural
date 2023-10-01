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

    /// <summary>Ano de lançamento do produto.</summary>
    public DateTime? DataLancamento { get; set; }

    /// <summary>ID do Autor do produto.</summary>
    public ushort? IDAutor { get; set; }

    /// <summary>ID da categoria do produto.</summary>
    public ushort? IDCategoria { get; set; }

    /// <summary>ID da Editora do produto.</summary>
    public ushort? IDEditora { get; set; }

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
    public Produto(int id, string titulo, DateTime? dataLancamento, ushort? iDAutor,
     ushort? iDCategoria, ushort? iDEditora, ProdutoEstado produtoEstado, ProdutoTipo produtoTipo,
     decimal custoAquisicao, decimal valorVenda, DateTime dataAquisicao, DateTime dataVenda)
    {
        ID = id;
        Titulo = titulo;
        DataLancamento = dataLancamento;
        IDAutor = iDAutor;
        IDCategoria = iDCategoria;
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
        DataLancamento = dto.DataLancamento;
        IDAutor = dto.IDAutor;
        IDCategoria = dto.IDCategoria;
        IDEditora = dto.IDEditora;
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
        DataLancamento = dto.DataLancamento;
        ProdutoEstado = dto.AlbumEstado;
        ProdutoTipo = dto.ProdutoTipo;
        CustoAquisicao = dto.CustoAquisicao;
        ValorVenda = dto.ValorVenda;
        DataAquisicao = dto.DataAquisicao;
        DataVenda = dto.DataVenda;
    }

}