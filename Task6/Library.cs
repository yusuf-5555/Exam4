public class Library : ILibrary
{
    List<Book> _books = new List<Book>();
    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void DeleteBook(int id)
    {
        try
        {
            var delbook = _books.FirstOrDefault(x => x.Id==id);
        _books.Remove(delbook);
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("list xoliyay");
            throw;
        }
    }

    public void SearchByAuthor(string author)
    {
        try
        {
            var authors = _books.Where(x => x.Author.ToLower().Trim().Contains(author.ToLower().Trim())).ToList();
         foreach (var item in authors)
        {
            System.Console.WriteLine(item.Id);
            System.Console.WriteLine(item.Author);
            System.Console.WriteLine(item.Title);
        }
        }
        catch (System.Exception)
        {
            System.Console.Write("ixeli author nest");
            throw;
        }
    }

    public void SearchByTitle(string title)
    {
        var titles = _books.Where(x => x.Title.ToLower().Trim().Contains(title.ToLower().Trim())).ToList();
        foreach (var item in titles)
        {
            System.Console.WriteLine(item.Id);
            System.Console.WriteLine(item.Author);
            System.Console.WriteLine(item.Title);
        }
    }

    public void UpdateBook(Book book)
    {
        var upbook = _books.FirstOrDefault(x => x.Id == book.Id);
        upbook.Id = book.Id;
        upbook.Author = book.Author;
        upbook.Title = book.Title;
    }

    public void DisplayBooks()
    {
        foreach (var item in _books)
        {
            System.Console.WriteLine(item.Id);
            System.Console.WriteLine(item.Author);
            System.Console.WriteLine(item.Title);
        }
    }
}