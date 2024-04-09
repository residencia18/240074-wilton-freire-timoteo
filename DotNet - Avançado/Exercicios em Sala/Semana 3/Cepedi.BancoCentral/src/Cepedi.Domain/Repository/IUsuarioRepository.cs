using Cepedi.BancoCentral.Domain.Entities;
using Cepedi.BancoCentral.Shareable.Requests;
using Cepedi.BancoCentral.Shareable.Responses;

namespace Cepedi.BancoCentral.Domain.Repository;

public interface IUsuarioRepository
{
    Task<UsuarioEntity> CriarUsuarioAsync(UsuarioEntity usuario);
    Task<UsuarioEntity> ObtemUsuarioIdAsync(int idUsuario);
    Task<int> AlterarCursoAsync(UsuarioEntity usuario);
    Task<int> DeletarUsuarioAsync(UsuarioEntity usuario);
}
