using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVET
{
    class Gato : Mascotas
    {
        private float longsalto;

        public Gato(string nm, string di, float pe, int c, Fecha f) : base(c, nm, pe, di, f)
        {
            string nivel;
            nivel = Microsoft.VisualBasic.Interaction.InputBox("Ingresar dato: ", "Longitud de salto");
            this.longsalto = float.Parse(nivel);
            this.Soy = "Gato";
        }
    }
}
