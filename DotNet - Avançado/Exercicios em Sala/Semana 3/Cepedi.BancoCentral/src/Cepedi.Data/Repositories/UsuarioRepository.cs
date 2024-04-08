using Cepedi.BancoCentral.Domain;
using Cepedi.BancoCentral.Domain.Entities;
using Cepedi.BancoCentral.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Cepedi.BancoCentral.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<int> AlterarCursoAsync(UsuarioEntity usuario)
        {
            _context.Usuario.Update(usuario);
            return _context.SaveChangesAsync();
        }

        public async Task<UsuarioEntity> CriarUsuarioAsync(UsuarioEntity usuario)
        {
            _context.Usuario.Add(usuario);

            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioEntity> ObtemUsuarioIdAsync(int idUsuario)
            => await _context.Usuario.Where(usuario
                => usuario.Id == idUsuario).FirstOrDefaultAsync();
    }
}
