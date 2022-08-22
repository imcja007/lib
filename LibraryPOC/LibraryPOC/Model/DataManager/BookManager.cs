using LibraryPOC.Context;
using LibraryPOC.Controllers;

namespace LibraryPOC.Model.BookManager
{
    public class BookManager : IDataRepository<Book>
    {
        readonly DataContext _book;

        public BookManager(DataContext context)
        {
            _book = context;
        }

        public void Add(Book entity)
        {
            _book.Books.Add(entity);
            _book.SaveChanges();
        }

        public void Delete(Book entity)
        {
            _book.Books.Remove(entity);
            _book.SaveChanges();
        }

        public Book Get(int id)
        {
            return _book.Books.FirstOrDefault(e=>e.BookId==id);
        }

        public IEnumerable<Book> GetAll()
        {
           return _book.Books.ToList();
        }

        public void Update(Book book, Book entity)
        {
            if (entity == null)
                    return;
            book.DateOfIssue = entity.DateOfIssue;
            book.AuthorID = entity.AuthorID;    
            book.Publisher = entity.Publisher;
            book.Title = entity.Title;            
            book.Price = entity.Price;
            book.BookId = entity.BookId;
            book.Category = entity.Category;
            
        }
    }
}
