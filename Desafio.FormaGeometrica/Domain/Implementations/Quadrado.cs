namespace Desafio.FormaGeometrica.Domain.Implementations;

using Desafio.FormaGeometrica.Domain.Contracts;

internal class Quadrado : FormaGeometrica
{
    public int Lado { get; set; }

    public Quadrado(int lado)
    {
        Lado = lado;
        Area = CalcularArea();
    }

    public override decimal CalcularArea()
    {
        decimal area = Lado ^ 2;
        return area;
    }
}
