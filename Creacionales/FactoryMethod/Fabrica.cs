using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenioGOF.Creacionales.FactoryMethod
{
    /// <summary>
    /// La Frabrica produce intancias de una clase deseada, siempre que esta clase implemente la interfaz.
    /// En este ejemplo no se le podria pedir a la fabrica de Ferrari que cree un Lamborghini.
    /// Solo se le prodran pedir instancias de modelos de ferrari que implementen la interfaz IFerrari.
    /// </summary>
    internal class FabricaFerrari
    {
        public IFerrari CrearFerrari(string modelo)
        {
            switch (modelo)
            {
                case "A":
                    return new LaFerrari();
                case "B":
                    return new Roma();
                case "C":
                    return new FXX();
                default:
                    throw new ArgumentException("Modelo no valido");
            }
        }
    }
}
