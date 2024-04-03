//Program.cs
using System;

class Program
{
    static void Main()
    {
        var apiServer = new MyApiServer.ApiServer("http://localhost:2490/api/produits/");
        apiServer.Start();

        Console.WriteLine("API en cours d'exécution. Appuyez sur Enter pour quitter.");
        Console.ReadLine();

        apiServer.Stop();
    }
}
