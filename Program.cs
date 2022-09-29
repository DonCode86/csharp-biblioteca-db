// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=db-library;Integrated Security=True");
try
{
    Console.WriteLine("Inserisci Isbn");
    string isbn = Console.ReadLine();

    Console.WriteLine("Inserisci Pagine");
    int pages = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci Titolo");
    string title = Console.ReadLine();

    Console.WriteLine("Inserisci Anno");
    int year = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci Categoria");
    string category = Console.ReadLine();

    Console.WriteLine("Inserisci numero scaffale");
    int shelfcode = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci Autore");
    string author = Console.ReadLine();

    Console.WriteLine("Inserisci SerialNumber");
    string serialnumber = Console.ReadLine();


    connection.Open();

    string query = "INSERT INTO Book (Isbn, Pages, Title, Year, Category, Shelfcode, Author, SerialNumber) VALUES (@dato1, @dato2, @dato3, @dato4, @dato5, @dato6, @dato7, @dato8)";

    SqlCommand cmd = new SqlCommand(query, connection);

    cmd.Parameters.Add(new SqlParameter("@dato1", isbn));
    cmd.Parameters.Add(new SqlParameter("@dato3", pages));
    cmd.Parameters.Add(new SqlParameter("@dato2", title));
    cmd.Parameters.Add(new SqlParameter("@dato4", year));
    cmd.Parameters.Add(new SqlParameter("@dato5", category));
    cmd.Parameters.Add(new SqlParameter("@dato6", shelfcode));
    cmd.Parameters.Add(new SqlParameter("@dato7", author));
    cmd.Parameters.Add(new SqlParameter("@dato8", serialnumber));

    int affectedRows = cmd.ExecuteNonQuery();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    connection.Close();
}