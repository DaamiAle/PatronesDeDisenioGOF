using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenioGOF.Creacionales.FactoryMethod
{
    internal class LaFerrari : IFerrari
    {
        public int AcelerarMaximaVelocidad()
        {
            return 350;
        }
    }
}
