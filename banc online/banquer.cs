namespace Banquer;

public class banquer
{
    private Dictionary<string,client1> clients;

    public banquer()
    {
        clients = new Dictionary<string, client1>();
    }

    public void CreaClient(string nomNouClient)
    {
        clients.Add(nomNouClient, new client1(nomNouClient));
    }
    
    public string PosarDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            client.Saldo += quantitat;
            return $"{nomClient}: {quantitat} € ingressats correctament";
        } 
        return $"Tu no ets client {nomClient}";
    }

    public string TreureDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            var comissio = (int)quantitat / 100;
            if (quantitat + comissio > client.Saldo)
            {
                return $"{nomClient}: No tens {quantitat + comissio} € prou diners";
            }

            client.Saldo -= quantitat + comissio;
            return $"{nomClient}: Té {quantitat} € et queden {client.Saldo}";
        }
        return $"Tu no ets client {nomClient}";
    }
}