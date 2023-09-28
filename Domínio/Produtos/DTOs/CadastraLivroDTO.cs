using sebo_cultural.Domínio;
using sebo_cultural.Enums;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa um livro da plataforma.</summary>
public class CadastraLivroDTO
{
    /// <summary>Título do livro.</summary>
    public string Titulo { get; set; } = null!;


    /// <summary>Categoria do produto.</summary>
    public Categoria Genero { get; set; } = null!;

    /// <summary>Quantidade de páginas do livro.</summary>
    public int Paginas { get; set; }

    /// <summary>Ano de lançamento do livro.</summary>
    public int AnoLancamento { get; set; }

    /// <summary>Autor do livro.</summary>
    public int IDAutor { get; set; }

    /// <summary>Autor do livro.</summary>
    public Autor Autor { get; set; } = null!;

    /// <summary>ID da Editora do livro.</summary>
    public int IDEditora { get; set; }

    /// <summary>Editora do livro.</summary>
    public Editora Editora { get; set; } = null!;

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