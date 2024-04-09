using Cepedi.BancoCentral.Shareable.Responses;
using MediatR;

namespace Cepedi.BancoCentral.Shareable.Requests;   

public record DeletarUsuarioRequest : IRequest<DeletarUsuarioResponse>
{
    public int Id { get; set; } = default!;
}
