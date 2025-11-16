// Uma Localização tem Latitude e Longitude armazenadas em decimal
// A Latitude deve estar entre -90 e 90
// A Longitude deve estar entre -180 e 180

// Criar métodos/funções que movem uma Localização para Norte, Sul, Leste e Oeste
// Cada movimento deve receber um parâmetro decimal que indica a distância a ser movida
// Ex: Mover Norte 10.5 aumenta a Latitude em 10.5
// Se a Latitude ou Longitude ultrapassar os limites, deve girar para o lado oposto
// Ex: Se a Latitude for 95, deve ser ajustada para -85

// Implementar várias versões dessas funções, considerando o uso de classe (ou record class), 
// uso de struct (ou record struct), com e sem return, passando por cópia e por referência.

public struct Localizacao
{
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
}

 public class Mover
{
    public void VerPos(ref Localizacao pos)
    {
        Console.WriteLine($"Posição: \nLatitude: {pos.Latitude}, Longitude: {pos.Longitude}\n");
    }
    public void Norte(ref Localizacao pos, decimal distancia)
    {
        pos.Latitude += distancia;
        AjustarLatitude(ref pos);
        Console.WriteLine($"Movido {distancia} para Norte, posição atual: \n Latitude: {pos.Latitude}, Longitude: {pos.Longitude}\n");
    }

    public void Sul(ref Localizacao pos, decimal distancia)
    {
        pos.Latitude -= distancia;
        AjustarLatitude(ref pos);
        Console.WriteLine($"Movido {distancia} para Sul, posição atual: \n Latitude: {pos.Latitude}, Longitude: {pos.Longitude}\n");
    }

    public void Leste(ref Localizacao pos, decimal distancia)
    {
        pos.Longitude += distancia;
        AjustarLongitude(ref pos);
        Console.WriteLine($"Movido {distancia} para Leste, posição atual: \n Latitude: {pos.Latitude}, Longitude: {pos.Longitude}\n");
    }

    public void Oeste(ref Localizacao pos, decimal distancia)
    {
        pos.Longitude -= distancia;
        AjustarLongitude(ref pos);
        Console.WriteLine($"Movido {distancia} para Oeste, posição atual: \n Latitude: {pos.Latitude}, Longitude: {pos.Longitude}\n");
    }

    private void AjustarLatitude(ref Localizacao pos)
    {
        if (pos.Latitude > 90)
        {
            pos.Latitude = -90 + (pos.Latitude - 90);
        }
        else if (pos.Latitude < -90)
        {
            pos.Latitude = 90 + (pos.Latitude + 90);
        }
    }

    private void AjustarLongitude(ref Localizacao pos)
    {
        if (pos.Longitude > 180)
        {
            pos.Longitude = -180 + (pos.Longitude - 180);
        }
        else if (pos.Longitude < -180)
        {
            pos.Longitude = 180 + (pos.Longitude + 180);
        }
    }
    
}
    


