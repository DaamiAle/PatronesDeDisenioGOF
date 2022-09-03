using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenioGOF.Creacionales.AbstractFactory
{
    public abstract class Bebida
    {
        public void IdentificarBebida()
        {
            Console.WriteLine($"Soy {GetType().Name}");
        }
    }
    public class CocaCola : Bebida { }
    public class Limonada : Bebida { }
    public class Agua : Bebida { }
    public class Cocktail : Bebida { }
}
