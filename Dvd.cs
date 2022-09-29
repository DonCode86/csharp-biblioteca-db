
// See https://aka.ms/new-console-template for more information

public class Dvd : Product
{
    protected int duration;
    public Dvd(string serialNumber, int duration, string title, int year, string category, int shelfCode, string author) : base(serialNumber, title, year, category, shelfCode, author)
    {
        this.duration = duration;
    }
}