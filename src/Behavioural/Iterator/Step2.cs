namespace Iterator;

public class BookCollection : IEnumerable<Book>
{
    private List<Book> _books = new List<Book>();

    public void Add(Book book)
    {
        _books.Add(book);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return _books.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return _books.GetEnumerator();
    }
}