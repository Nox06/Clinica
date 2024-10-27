using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVET
{
    public partial class RazaL : Form
    {
        public RazaL()
        {
            InitializeComponent();
        }

        private void VER_Click(object sender, EventArgs e)
        {
            lista.Clear();
            foreach(Mascotas aux in Gerente.ListaMascota)
            {
                if(aux.Soy == "Perro")
                {
                    if (racita.Text == aux.getRaza())
                    {
                        lista.Items.Add(aux.Nombre);
                    }
                }
            }
        }
    }
}
