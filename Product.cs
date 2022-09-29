
// See https://aka.ms/new-console-template for more information

public class Product
{
    protected string serialNumber;
    protected string title;
    protected int year;
    protected string category;
    protected bool isBorrowed;
    protected int shelfCode;
    protected string author;
   
    public Product (string serialNumber, string title, int year, string category, int shelfCode, string author)
    {
        this.serialNumber = serialNumber;
        this.title = title;
        this.year = year;
        this.category = category;
        this.isBorrowed = false;
        this.shelfCode = shelfCode;
        this.author = author; 
    }
    public Product()
    {
        title = "";
    }

    public string Title
    {
        get { return title; }
        
    }

    public bool IsBorrowed
    {
        get { return isBorrowed; }
        set { isBorrowed = value; }
    }

    public string SerialNumber
    {
        get
        {
            return this.serialNumber;
        }
    }
   
}