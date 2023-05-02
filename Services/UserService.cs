using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using AppAcceso.Models;

namespace AppAcceso.Services
{
    public interface IUserService
    {
        Task<int> CreateAsync(string nombre, string claveAcceso, int nivelAccesoId, int zonaAccesoId);
    }

    public class UserService : IUserService
    {
        private readonly IConfiguration _configuration;
        private readonly DbContext _dbContext;

        public UserService()
        {
        }

        public UserService(IConfiguration configuration, DbContext dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        public async Task<int> CreateAsync(string nombre, string claveAcceso, int nivelAccesoId, int zonaAccesoId)
        {
            var nombreParam = new SqlParameter("@NombreUsuario", nombre);
            var claveAccesoParam = new SqlParameter("@ClaveAcceso", claveAcceso);
            var nivelAccesoIdParam = new SqlParameter("@NivelAccesoId", nivelAccesoId);
            var zonaAccesoIdParam = new SqlParameter("@ZonaAccesoId", zonaAccesoId);
            var result = await _dbContext.Database.ExecuteSqlRawAsync("EXEC dbo.CreateUser @NombreUsuario, @ClaveAcceso, @NivelAccesoId, @ZonaAccesoId", nombreParam, claveAccesoParam, nivelAccesoIdParam, zonaAccesoIdParam);

            return result;
        }

        internal void CrearUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
