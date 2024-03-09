var book1 = new Book();
book1.Id = 1;
book1.Author = "Sadriddin Ayni";
book1.Title = "Doxunda";
var book2 = new Book();
book2.Id = 2;
book2.Author = "Hotami toy";
book2.Title = "Maktabi kuhna";
var book3 = new Book();
book3.Id = 3;
book3.Author = "Sadriddin Najmiddin";
book3.Title = "Maktabi kuhna";
var book4 = new Book();
book4.Id = 4;
book4.Author = "Ayni Rudaki";
book4.Title = "Maktabi nav";
var book5 = new Book();
book5.Id = 4;
book5.Author = "Sadriddin Ayni";
book5.Title = "Maktabi kuhna";

var library = new Library();
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);
library.AddBook(book4);

for(;;)
{
    System.Console.Write("Chi kor kardan mexohed(add,delete,update,display,search by title, search by author): ");
    string method = Console.ReadLine();

    if(method == "add")
    {
        var book6 = new Book();
        System.Console.Write("Id: ");
        book6.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Title: ");
        book6.Title = Console.ReadLine();
        System.Console.Write("Author: ");
        book6.Author = Console.ReadLine();
        library.AddBook(book6);
    }
    else if(method == "delete")
    {
        System.Console.Write("Kadom kitoba mexohen ud knen,id: ");
        var bookid = Convert.ToInt32(Console.ReadLine());
        library.DeleteBook(bookid);
    }
    else if(method == "update")
    {
        var book7 = new Book();
        System.Console.Write("id: ");
        book7.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Author: ");
        book7.Author = Console.ReadLine();
        System.Console.Write("Title: ");
        book7.Title = Console.ReadLine();
        library.UpdateBook(book7);
    }
    else if(method == "display")
    {
        library.DisplayBooks();
    }
    else if(method == "search by title")
    {
        System.Console.Write("Search by title: ");
        var bytitle = Console.ReadLine();
        library.SearchByTitle(bytitle);
    }
    else if(method == "search by author")
    {
        System.Console.WriteLine("Search by author: ");
        var byauthor = Console.ReadLine();
        library.SearchByAuthor(byauthor);
    }
}