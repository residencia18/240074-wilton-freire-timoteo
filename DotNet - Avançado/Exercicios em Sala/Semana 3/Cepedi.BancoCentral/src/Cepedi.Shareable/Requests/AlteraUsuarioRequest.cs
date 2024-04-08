using Cepedi.Shareable.Responses;
using MediatR;
public record AlteraUsuarioRequest : IRequest<AlterarUsuarioResponse>
{
    public int Id { get; set; } = default!;
    public string Nome { get; set; } = default!;

    public DateTime DataNascimento { get; set; }

    public string Cpf { get; set; } = default!;

    public string Celular { get; set; } = default!;

    public bool CelularValidado { get; set; }

    public string Email { get; set; } = default!;
}
