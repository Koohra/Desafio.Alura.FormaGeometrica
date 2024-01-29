using Desafio.FormaGeometrica.Domain.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.FormaGeometrica.Domain.Presentation.Menus
{
    internal static class MenuCalcularTriangulo
    {
        public static void Executar(int ladoBase, int altura)
        {
            var triangulo = new Triangulo(ladoBase, altura);

            Console.WriteLine($"A área do triangulo com os lados: {ladoBase} , {altura}.\n É igual: {triangulo.Area}");
        }
    }
}
