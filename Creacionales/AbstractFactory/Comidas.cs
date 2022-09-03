

namespace PatronesDeDisenioGOF.Creacionales.AbstractFactory
{
    public abstract class Comida
    {
        public void IdentificarComida()
        {
            Console.WriteLine($"Soy {GetType().Name}");
        }
    }
    public class Pizza : Comida { }
    public class Hamburguesa : Comida { }
    public class PolloFrito : Comida { }
    public class Sandwich : Comida { }
    public class PapasFritas : Comida { }
}
