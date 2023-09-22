using sebo_cultural.Domínio;

namespace sebo_cultural.DTOS;


/// <summary>DTO que representa uma editora de um ou mais livros da plataforma.</summary>
public class EditoraDTO
{
    /// <summary>Nome da editora.</summary>
    public string NomeEditora { get; set; } = null!;


    /// <summary>Coleção de livros do Autor.</summary>
    public ICollection<Produto>? Produto { get; set; }

}