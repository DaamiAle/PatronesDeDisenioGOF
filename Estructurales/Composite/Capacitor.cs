

namespace PatronesDeDisenioGOF.Estructurales.Composite
{
    public class Capacitor : Componente
    {
        private readonly decimal capacitancia;
        public Capacitor(string descripcion, int peso, decimal costo, decimal capacitancia) : base(descripcion, peso, costo)
        {
            this.capacitancia = capacitancia;
        }
        public decimal Capacitancia() => capacitancia;
    }
}
