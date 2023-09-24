namespace sebo_cultural.Enums;

/// <summary>Enum que representa o estado de conservação de um produto da plataforma.</summary>
public enum ProdutoEstado
{
    /// <summary>Produto livro.</summary>
    NovoEmbalado = 0,

    /// <summary>Produto disco de viníl.</summary>
    Conservado = 1,

    /// <summary>Produto de mídia CD.</summary>
    AvariasAparentes = 2,

    /// <summary>Produto de mídia CD.</summary>
    AvariasSeveras = 3
}