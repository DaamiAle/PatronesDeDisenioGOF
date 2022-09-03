

namespace PatronesDeDisenioGOF.Creacionales.Singleton
{
    /// <summary>
    /// Singleton que representa la lista de paises del planeta.
    /// Solo existe 1 lista de paises en el planeta
    /// </summary>
    public class ListaDePaises
    {
        private static ListaDePaises instancia;
        private readonly List<string> paises = new();

        private ListaDePaises() { }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Instancia unica del sigleton.</returns>
        public static ListaDePaises ObetenerListaDePaises()
        {
            if (instancia == null)
            {
                instancia = new();
            }
            return instancia;
        }
        public List<string> Paises() => paises;
    }
}
