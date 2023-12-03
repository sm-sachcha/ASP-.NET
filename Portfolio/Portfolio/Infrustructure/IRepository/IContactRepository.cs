using Portfolio.Models;

namespace Portfolio.Infrustructure.IRepository
{
    public interface IContactRepository
    {
        object IContactRepository { get; }

        Task<IEnumerable<Contact>>GetAll();
        Task<Contact> GetById(int id);
        Task Add(Contact contact);
        Task Update(Contact contact);
        Task Delete(int id);
    }
}
