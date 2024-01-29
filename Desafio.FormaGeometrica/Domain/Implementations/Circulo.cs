namespace Desafio.FormaGeometrica.Domain.Implementations;

using Desafio.FormaGeometrica.Domain.Contracts;

internal class Circulo : FormaGeometrica
{
    public decimal Pi { get; set; }
    public int Raio { get; set; }
    public decimal Perimetro { get; set; }

    public Circulo(int raio)
    {
        Raio = raio;
        Pi = (decimal)Math.PI;
        Area = CalcularArea();
        Perimetro = CalcularPerimetro();
    }
    public override decimal CalcularArea()
    {
        decimal area = Pi * (decimal)Math.Pow(Raio, 2);
        return area;
    }

    public decimal CalcularPerimetro()
    {
        decimal perimetro = 2 * Pi * Raio;
        return perimetro;
    }
}
