using LibraryPOC.Controllers;
using LibraryPOC.Context;

namespace LibraryPOC.Model.AuthorManager
{
    public class AuthorManager : IDataRepository<Author>
    {
        readonly DataContext _author;
        public AuthorManager(DataContext context)
        {
            _author = context;
        }

        public void Add(Author entity)
        {
            _author.Authors.Add(entity);
            _author.SaveChanges();
        }

        public void Delete(Author entity)
        {
            _author.Authors.Remove(entity);
            _author.SaveChanges();
        }

        public Author Get(int id)
        {
            return _author.Authors.FirstOrDefault(e => e.AuthorID == id);
        }

        public IEnumerable<Author> GetAll()
        {
            return _author.Authors.ToList();
        }

        public void Update(Author author, Author entity)
        {
            if (entity == null)
                return;
            author.AuthorID = entity.AuthorID;
            author.Country = entity.Country;
            author.Name = entity.Name;

        }
    }
}