namespace Desafio.FormaGeometrica.Domain.Contracts;

internal abstract class FormaGeometrica
{
    public decimal Area { get; set; }
    public virtual decimal CalcularArea()
    {
        return 0;
    }
}
