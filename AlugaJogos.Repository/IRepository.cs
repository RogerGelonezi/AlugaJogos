using System.Linq;
using System.Threading.Tasks;

namespace AlugaJogos.Persistence
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> All { get; }

        TEntity Find(int key);
        Task<TEntity> FindAsync(int key);

        void Save(params TEntity[] obj);
        Task SaveAsync(params TEntity[] obj);

        void Alter(params TEntity[] obj);
        Task AlterAsync(params TEntity[] obj);

        void Delete(params TEntity[] obj);
        Task DeleteAsync(params TEntity[] obj);
    }
}
