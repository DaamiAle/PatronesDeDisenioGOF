using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenioGOF.Creacionales.AbstractFactory
{
    public interface ISectorRestaurante
    {
        public Bebida ObtenerBebida(string bebida);
        public Comida ObtenerComida(string comida);
    }
    public class Barra : ISectorRestaurante
    {
        public Bebida ObtenerBebida(string bebida)
        {
            Bebida laBebida;
            switch (bebida.ToLower())
            {
                case "cocacola":
                    laBebida = new CocaCola();
                    break;
                case "limonada":
                    laBebida = new Limonada();
                    break;
                case "agua":
                    laBebida = new Agua();
                    break;
                case "cocktail":
                    laBebida = new Cocktail();
                    break;
                default:
                    throw new ArgumentException("Bebida no valida");
            }
            return laBebida;
        }

        public Comida ObtenerComida(string comida)
        {
            return null;
        }
    }
    public class Cocina : ISectorRestaurante
    {
        public Comida ObtenerComida(string comida)
        {
            Comida laComida;
            switch (comida.ToLower())
            {
                case "pizza":
                    laComida = new Pizza();
                    break;
                case "hamburguesa":
                    laComida = new Hamburguesa();
                    break;
                case "pollofrito":
                    laComida = new PolloFrito();
                    break;
                case "sandwich":
                    laComida = new Sandwich();
                    break;
                case "papasfritas":
                    laComida = new PapasFritas();
                    break;
                default:
                    throw new ArgumentException("Comida no valida");
            }
            return laComida;
        }
        public Bebida ObtenerBebida(string bebida)
        {
            return null;
        }
    }
}
