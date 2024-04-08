using Cepedi.BancoCentral.Domain.Entities;

namespace Cepedi.BancoCentral.Domain.Repository;

public interface IUsuarioRepository
{
    Task<UsuarioEntity> CriarUsuarioAsync(UsuarioEntity usuario);
    Task<UsuarioEntity> ObtemUsuarioIdAsync(int idUsuario);
    Task<int> AlterarCursoAsync(UsuarioEntity usuario);
}
