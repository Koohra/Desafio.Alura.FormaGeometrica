using Desafio.FormaGeometrica.Domain.Implementations;

namespace Desafio.FormaGeometrica.Domain.Presentation.Menus;

internal static class MenuCalcularCirculo
{
    public static void Executar(int raio)
    {
        var circulo = new Circulo(raio);
        Console.WriteLine($"A área do circulo com o raio de: {raio} é igual a {circulo.Area.ToString("F2")}");
        Console.WriteLine($"O perimetro do circulo é igual a {circulo.Perimetro.ToString("F2")}");
    }
}
