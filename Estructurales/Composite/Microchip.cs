

namespace PatronesDeDisenioGOF.Estructurales.Composite
{
    public class Microchip :Componente
    {
        private readonly int cantidadTransistores;
        public Microchip(string nombre, int peso, decimal costo, int cantidadTransistores) : base(nombre, peso, costo)
        {
            this.cantidadTransistores = cantidadTransistores;
        }
        public int CantidadTransistores() => cantidadTransistores;
    }
}
