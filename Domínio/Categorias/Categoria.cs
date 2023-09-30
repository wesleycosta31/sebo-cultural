using sebo_cultural.DTOS;
using sebo_cultural.Enums;
namespace sebo_cultural.Domínio;

/// <summary>Classe que representa uma categoria de um produto da plataforma.</summary>
public class Categoria
{
    /// <summary>Código de identificação da categoria.</summary>
    public int ID { get; set; }

    /// <summary>Tipo da categoria refente ao produto cadastrado.</summary>
    public string CategoriaTipo { get; set; } = null!;

    /// <summary>Construtor com parâmetros.</summary>
    public Categoria(int id, string categoriaTipo, ProdutoTipo produtoTipo)
    {
        ID = id;
        CategoriaTipo = categoriaTipo;
    }

    /// <summary>Construtor utilizado no processo de cadastro de uma nova categoria.</summary>
    /// <param name="dto">DTO do processo de cadastro de uma nova categoria.</param>
    public Categoria(CategoriaDTO dto)
    {
        CategoriaTipo = dto.Categoria;
    }
}