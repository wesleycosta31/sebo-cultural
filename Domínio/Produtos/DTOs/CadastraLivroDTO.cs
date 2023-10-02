using sebo_cultural.Domínio;
using sebo_cultural.Enums;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa um livro da plataforma.</summary>
public class CadastraLivroDTO
{
    /// <summary>Título do livro.</summary>
    public string Titulo { get; set; } = null!;

    /// <summary>Ano de lançamento do livro.</summary>
    public DateTime? DataLancamento { get; set; }

    /// <summary>ID do Autor do produto.</summary>
    public ushort IDAutor { get; set; }
    
    /// <summary>ID da categoria do produto.</summary>
    public ushort IDCategoria { get; set; }

    /// <summary>ID da Editora do produto.</summary>
    public ushort IDEditora { get; set; }

    /// <summary>Estado de consevação do livro.</summary>
    public ProdutoEstado LivroEstado { get; set; }

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

}