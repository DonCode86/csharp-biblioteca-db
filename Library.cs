
// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

public class Library
{
    protected string name;
    private List<Book> books;
    private List<Dvd> dvd;

    public Library(string name)
    {
        this.name = name;
    }

    public List<Book> Books
    {
        get { return books; }
        set { books = value; }
    }

    public List<Dvd> Dvd
    {
        get { return dvd; }
        set { dvd = value; }
    }
    public Product GetSearch(string value)
    {
        
        foreach (Dvd dvd in dvd)
        {
            if (dvd.SerialNumber == value || dvd.Title == value)
            {
                return dvd;
            }
        }
        foreach (Book book in books)
        {
            if (book.SerialNumber == value || book.Title == value)
            {
                return book;
            }
        }
        return new Product();
    }
}