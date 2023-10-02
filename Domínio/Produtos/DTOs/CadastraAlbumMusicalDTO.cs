using sebo_cultural.Domínio;
using sebo_cultural.Enums;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa um livro da plataforma.</summary>
public class CadastraAlbumMusicalDTO
{
    /// <summary>Título do album.</summary>
    public string Titulo { get; set; } = null!;

    public DateTime? DataLancamento { get; set; }

    /// <summary>ID do Autor do produto.</summary>
    public ushort? IDAutor { get; set; }

    /// <summary>ID da categoria do produto.</summary>
    public ushort? IDCategoria { get; set; }

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