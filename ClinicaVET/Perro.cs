using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVET
{
     class Perro : Mascotas
     {
        private String raza;

        public Perro(string nm, string di, float pe, int c, Fecha f): base(c,nm,pe,di,f)
        {
            this.raza = Microsoft.VisualBasic.Interaction.InputBox("Ingresar dato: ", "RAZA");
            this.Soy = "Perro";
        }

        public override String getRaza()
        {
            return raza;
        }
     }
}
