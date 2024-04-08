using Cepedi.BancoCentral.Domain.Entities;
using Cepedi.BancoCentral.Domain.Repository;
using Cepedi.Shareable.Requests;
using Cepedi.Shareable.Responses;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Cepedi.BancoCentral.Domain.Handlers;
public class AlteraUsuarioRequestHandler : IRequestHandler<AlteraUsuarioRequest, AlterarUsuarioResponse>
{
    private readonly ILogger<AlteraUsuarioRequestHandler> _logger;
    private readonly IUsuarioRepository _usuarioRepository;

    public AlteraUsuarioRequestHandler(IUsuarioRepository usuarioRepository, ILogger<AlteraUsuarioRequestHandler> logger)
    {
        _usuarioRepository = usuarioRepository;
        _logger = logger;
    }
    public async Task<AlterarUsuarioResponse> Handle(AlteraUsuarioRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var usuarioEncontrado = await _usuarioRepository.ObtemUsuarioIdAsync(request.Id);
            if (usuarioEncontrado == null)
            {
                throw new Exception("Usuario não encontrado");
            }
            usuarioEncontrado.Nome = request.Nome;
            usuarioEncontrado.DataNascimento = request.DataNascimento;
            usuarioEncontrado.Celular = request.Celular;
            usuarioEncontrado.CelularValidado = request.CelularValidado;
            usuarioEncontrado.Email = request.Email;

            await _usuarioRepository.AlterarCursoAsync(usuarioEncontrado);
            return new AlterarUsuarioResponse(usuarioEncontrado.Id, usuarioEncontrado.Nome);
        }
        catch (System.Exception)
        {

            throw;
        }
        throw new NotImplementedException();
    }
}
