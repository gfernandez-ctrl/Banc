namespace Banquer;

public class client1
{
    public client1(string nomClient)
    {
        Nom = nomClient;
        Saldo = 0;
    }
    public string Nom { get; }
    
    public int Saldo { get; set; } = 0;


}