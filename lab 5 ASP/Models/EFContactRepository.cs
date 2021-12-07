using System.Linq;

namespace Lab_5_2.Models
{
    public class EFContactRepository:IContactRepository
    {
        private ApplicationDbContext _context;

        public EFContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Contact> products => _context.Contacts;
    }
}