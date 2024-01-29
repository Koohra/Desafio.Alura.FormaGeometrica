namespace Desafio.FormaGeometrica.Domain.Implementations;

using Desafio.FormaGeometrica.Domain.Contracts;

internal class Triangulo : FormaGeometrica
{
    public int LadoBase { get; set; }
    public int Altura { get; set; }

    public Triangulo(int ladoBase, int altura)
    {
        LadoBase = ladoBase;
        Altura = altura;
        Area = CalcularArea();
    }

    public override decimal CalcularArea()
    {
        decimal area = LadoBase * Altura / 2;
        return area;
    }

    //implementar metodos de condições de existencia do triangulo e suas especificidades 
}
