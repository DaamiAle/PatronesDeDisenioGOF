

namespace PatronesDeDisenioGOF.Estructurales.Composite
{
    public class PlacaVideo : Componente
    {
        private readonly List<Componente> componentes;
        public PlacaVideo(string nombre, int peso, decimal costo) : base(nombre, peso, costo)
        {
            componentes = new();
        }
        public List<Componente> Componentes() => componentes;
        override public decimal Costo() => costo + componentes.Sum(it => it.Costo());

    }
}
