using sebo_cultural.Domínio;
using sebo_cultural.Enums;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa um livro da plataforma.</summary>
public class CadastraAlbumMusicalDTO
{
    /// <summary>Título do album.</summary>
    public string Titulo { get; set; } = null!;

    /// <summary>Gênero do album.</summary>
    public Categoria Genero { get; set; } = null!;

    /// <summary>Ano de lançamento do livro.</summary>
    public int AnoLancamento { get; set; }

    /// <summary>Autor do livro.</summary>
    public int IDAutor { get; set; }

    /// <summary>ID da Editora do livro.</summary>
    public int IDEditora { get; set; }

    /// <summary>Estado de consevação do album.</summary>
    public ProdutoEstado AlbumEstado { get; set; }   

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