using sebo_cultural.DTOS;
using sebo_cultural.Enums;
namespace sebo_cultural.Domínio;

/// <summary>Classe que representa um autor de um livro da plataforma.</summary>
public class Autor
{
    /// <summary>Código de identificação do autor.</summary>
    public int ID { get; set; }

    /// <summary>Nome completo do autor.</summary>
    public string Nome { get; set; } = null!;

    /// <summary>Ano de nascimento do autor.</summary>
    public DateOnly? DataNascimento { get; set; }

    /// <summary>Código de identificação do produto.</summary>
    public int? IDProduto { get; set; }

    /// <summary>Tipo do produto.</summary>
    public ProdutoTipo? ProdutoTipo { get; set; }

    /// <summary>Construtor com parâmetros.</summary>
    public Autor(int id, string nome, DateOnly anoNascimento, int iDProduto, ProdutoTipo produtoTipo)
    {
        ID = id;
        Nome = nome;
        DataNascimento = anoNascimento;
        IDProduto = iDProduto;
        ProdutoTipo = produtoTipo;
    }

    /// <summary>Construtor utilizado no processo de cadastro de um autor.</summary>
    /// <param name="dto">DTO do processo de cadastro de autor.</param>
    public Autor(CadastrarAutorDTO dto)
    {
        Nome = dto.Nome;
        DataNascimento = dto.DataNascimento;
        IDProduto = dto.IDProduto;
        ProdutoTipo = dto.ProdutoTipo;  
    }
}