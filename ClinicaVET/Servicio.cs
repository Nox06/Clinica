using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVET
{
    class Servicio
    {
        public int codigo;
        public float monto; 

        public Servicio()
        {

        }

        public Servicio(int c, float m)
        {
            this.codigo = c;
            this.monto = m;
        }
    }
}
