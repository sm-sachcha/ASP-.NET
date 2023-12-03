using Microsoft.EntityFrameworkCore;
using Portfolio.Data;
using Portfolio.Infrustructure.IRepository;
using Portfolio.Models;

namespace Portfolio.Infrustructure.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;

        public object IContactRepository => throw new NotImplementedException();

        public async Task Add(Contact contact)
        {
            await _context.Contact.AddAsync(contact);
            _context.SaveChanges();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
