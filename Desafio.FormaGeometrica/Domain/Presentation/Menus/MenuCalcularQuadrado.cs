

using Desafio.FormaGeometrica.Domain.Implementations;

namespace Desafio.FormaGeometrica.Domain.Presentation.Menus;

internal static class MenuCalcularQuadrado
{
    public static void Executar(int lado)
    {
        var quadrado = new Quadrado(lado);

        Console.WriteLine($"A área do quadrado com o lado de {lado} é igual: {quadrado.Area}");
    }
}
