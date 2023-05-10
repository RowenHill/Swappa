

using Swappa.Infrastructure.Interfaces;

namespace Swappa.Infarstructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SwappaContext _context;
        public UnitOfWork(SwappaContext context)
        {
            _context = context;
            ApplicationUsers = new ApplicationUserRepository(_context);
            Categories = new CategoryRepository(_context);
        }


        public IApplicationUserRepository ApplicationUsers { get; private set; }
        public ICategoryRepository Categories { get; private set; }
        /// <summary>
        /// Here is where we commit a transaction.
        /// </summary>
        /// <returns></returns>

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    
    
    }
}
