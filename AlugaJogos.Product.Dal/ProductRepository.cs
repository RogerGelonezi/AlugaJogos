using System.Linq;
using System.Threading.Tasks;

namespace AlugaJogos.Persistence
{
    public class ProductRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> All => _context.Set<TEntity>().AsQueryable();

        public void Alter(params TEntity[] obj)
        {
            _context.Set<TEntity>().UpdateRange(obj);
            _context.SaveChanges();
        }

        public async Task AlterAsync(params TEntity[] obj)
        {
            _context.Set<TEntity>().UpdateRange(obj);
            await _context.SaveChangesAsync();
        }

        public void Delete(params TEntity[] obj)
        {
            _context.Set<TEntity>().RemoveRange(obj);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(params TEntity[] obj)
        {
            _context.Set<TEntity>().RemoveRange(obj);
            await _context.SaveChangesAsync();
        }

        public TEntity Find(int key)
        {
            return _context.Find<TEntity>(key);
        }

        public async Task<TEntity> FindAsync(int key)
        {
            return await _context.FindAsync<TEntity>(key);
        }

        public void Save(params TEntity[] obj)
        {
            _context.Set<TEntity>().AddRange(obj);
            _context.SaveChanges();
        }

        public async Task SaveAsync(params TEntity[] obj)
        {
            _context.Set<TEntity>().AddRange(obj);
            await _context.SaveChangesAsync();
        }
    }
}
