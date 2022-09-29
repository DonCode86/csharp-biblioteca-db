
// See https://aka.ms/new-console-template for more information

public class Book : Product
{
    
    protected int pages;
    public Book(string isbn, int pages, string title, int year, string category, int shelfCode, string author, int serialNumber) : base(isbn, title, year, category, shelfCode, author)
    {
        this.pages = pages;
    }
}
