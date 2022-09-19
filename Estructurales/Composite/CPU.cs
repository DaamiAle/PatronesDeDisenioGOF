

namespace PatronesDeDisenioGOF.Estructurales.Composite
{
    public class CPU : Componente
    {
        private readonly List<Componente> componentes;

        public CPU(string descripcion, int peso, decimal costo) : base(descripcion, peso, costo)
        {
            componentes = new();
        }
        
    }
}
