using sebo_cultural.Domínio;
using sebo_cultural.Enums;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa uma categoria de um produto da plataforma.</summary>
public class CategoriaDTO
{
    /// <summary>Tipo da categoria refente ao produto cadastrado.</summary>
    public string Categoria { get; set; } = null!;

    /// <summary>Enumerado da categoria refente ao produto cadastrado.</summary>
    public CategoriaProdutoTipo CategoriaProdutoTipo { get; set; }

}