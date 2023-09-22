using Relier.Security.Domain.Users;
using sebo_cultural.Domínio;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa uma categoria de um produto da plataforma.</summary>
public class CategoriaDTO
{
    public string CategoriaTipo { get; set; } = null!;

    public ProdutoTipo ProdutoTipo { get; set; }

}