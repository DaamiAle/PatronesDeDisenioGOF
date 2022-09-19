

namespace PatronesDeDisenioGOF.Estructurales.Composite
{
    abstract public class Componente
    {
        protected decimal costo;
        protected string descripcion;
        protected int peso;
        public Componente(string descripcion, int peso, decimal costo)
        {
            this.descripcion = descripcion;
            this.peso = peso;
            this.costo = costo;
        }
        virtual public decimal Costo() => costo;
        virtual public string Descripcion() => descripcion;
        virtual public int Peso() => peso;
        public void Costo(decimal value) => costo = value;
    }
}
