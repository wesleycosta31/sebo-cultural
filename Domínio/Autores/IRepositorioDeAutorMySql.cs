namespace sebo_cultural.Domínio;

public interface IRepositorioDeAutorMySql
{
    /// <summary>Obtem as informações de um autor no repositório com base em código de identificação.</summary>
    /// <param name="iDAutor">Endereço de e-mail do usuário que será utilizado como filtro.</param>
    /// <returns>Entidade que representa o autor encontrado.</returns>
    Task<Autor> ObterAutorByIDAsync(ushort iDautor);
}