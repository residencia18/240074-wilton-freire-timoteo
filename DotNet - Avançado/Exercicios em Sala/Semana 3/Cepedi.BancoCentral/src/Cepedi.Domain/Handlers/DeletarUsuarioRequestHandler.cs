using Cepedi.BancoCentral.Domain.Repository;
using Cepedi.BancoCentral.Shareable.Requests;
using Cepedi.BancoCentral.Shareable.Responses;
using MediatR;

namespace Cepedi.BancoCentral.Domain.Handlers;

public class DeletarUsuarioRequestHandler : IRequestHandler<DeletarUsuarioRequest, DeletarUsuarioResponse>
{
    private readonly IUsuarioRepository usuarioRepository;

    public DeletarUsuarioRequestHandler(IUsuarioRepository usuarioRepository)
    {
       _usuarioRepository = usuarioRepository; 
    }

    public async Task<DeletarUsuarioResponse> Handle(DeletarUsuarioRequest request, CancellationToken cancellationToken)
    {
        var usuario = await _usuarioRepository.ObtemUsuarioIdAsync(request.Id);
        if (usuario == null)
        {
            return new DeletarUsuarioResponse(false);
        }
        else
        {
            await _usuarioRepository.DeletarUsuarioAsync(usuario);
            return new DeletarUsuarioResponse(true);
        }
    }
}
