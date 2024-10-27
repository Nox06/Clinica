using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVET
{
    class Fecha
    {
        public int dia;
        public int mes;
        public int anio;

        public Fecha()
        {

        }

        public Fecha(int d, int m, int a)
        {
            this.dia = d;
            this.mes = m;
            this.anio = a;
        }

        public bool verifique_si_esta(Fecha f1, Fecha f2)
        {
            String fe1 = f1.dia.ToString() + "/" + f1.mes.ToString() + "/" + f1.anio.ToString();
            String fe2 = f2.dia.ToString() + "/" + f2.mes.ToString() + "/" + f2.anio.ToString();
            String fe = this.dia.ToString() + "/" + this.mes.ToString() + "/" + this.anio.ToString();

            DateTime fecha1 = Convert.ToDateTime(fe1);
            DateTime fecha2 = Convert.ToDateTime(fe2);
            DateTime fecha = Convert.ToDateTime(fe);

            if (fecha1 <= fecha2 && fecha >= fecha1)
            {
                return true;
            }
            else
                return false;
        }
    }
}
