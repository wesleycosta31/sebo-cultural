using sebo_cultural.Domínio;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa um livro da plataforma.</summary>
public class CadastraLivroDTO
{
    /// <summary>Título do livro.</summary>
    public string Titulo { get; set; } = null!;


    /// <summary>Categoria do produto.</summary>
    public Categoria Tema { get; set; } = null!;

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

    public int LivroQuantidade { get; set; }

}