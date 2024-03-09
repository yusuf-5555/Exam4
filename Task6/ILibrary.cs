interface ILibrary
{
    void AddBook(Book book);
    void DisplayBooks();
    void UpdateBook(Book book);
    void DeleteBook(int id);
    void SearchByTitle(string title);
    void SearchByAuthor(string author);
}