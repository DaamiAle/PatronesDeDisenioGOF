using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenioGOF.Creacionales.Prototype
{
    public class Propiedad : ICloneable
    {
        private string direccion;
        private int antiguedad;
        private int ambientes;
        private string dueño;

        public Propiedad(string direccion, int antiguedad, int ambientes, string dueño)
        {
            this.direccion = direccion;
            this.antiguedad = antiguedad;
            this.ambientes = ambientes;
            this.dueño = dueño;
        }

        public object Clone()
        {
            return new Propiedad(direccion, antiguedad, ambientes, dueño);
        }
    }
}
