using sebo_cultural.Domínio;
using sebo_cultural.Enums;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa um livro da plataforma.</summary>
public class CadastraAlbumMusicalDTO
{
    /// <summary>Título do album.</summary>
    public string Titulo { get; set; } = null!;

    /// <summary>Gênero do album.</summary>
    public Categoria Tema { get; set; } = null!;

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

    /// <summary>Estado de consevação do album.</summary>
    public ProdutoEstado AlbumEstado { get; set; }   

    /// <summary>Tipo do produto.</summary>
    public ProdutoTipo ProdutoTipo { get; set; }
}