// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=db-library;Integrated Security=True");
try
{
    Console.WriteLine("Inserisci Pagine");
    int pages = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci Titolo");
    string title = Console.ReadLine();


    
    connection.Open();

    string query = "INSERT INTO document (Pages, Title) VALUES (@dato1, @dato2)";

    SqlCommand cmd = new SqlCommand(query, connection);
    SqlDataReader reader = cmd.ExecuteReader();

    cmd.Parameters.Add(new SqlParameter("@dato1", pages));
    cmd.Parameters.Add(new SqlParameter("@dato2", title));

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