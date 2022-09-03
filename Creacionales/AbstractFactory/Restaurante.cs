using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenioGOF.Creacionales.AbstractFactory
{
    /// <summary>
    /// Es una fabrica de fabricas. Pero rompe el principio de Segregacion de interfaces.
    /// </summary>
    public class Restaurante
    {
        public ISectorRestaurante ObetenerSectorDeProduccion(string sector)
        {
            ISectorRestaurante elSector;
            switch (sector.ToLower())
            {
                case "barra":
                    elSector = new Barra();
                    break;
                case "cocina":
                    elSector = new Cocina();
                    break;
                default:
                    throw new ArgumentException("Sector no valido");
            }
            return elSector;
        }
    }
}
