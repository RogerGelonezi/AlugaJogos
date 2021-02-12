using System.Linq;
using System.Threading.Tasks;

namespace AlugaJogos.Persistence
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> All { get; }

        TEntity Find(int key);
        Task<TEntity> FindAsync(int key);

        void Incluir(params TEntity[] obj);
        Task IncluirAsync(params TEntity[] obj);

        void Alterar(params TEntity[] obj);
        Task AlterarAsync(params TEntity[] obj);

        void Excluir(params TEntity[] obj);
        Task ExcluirAsync(params TEntity[] obj);
    }
}
