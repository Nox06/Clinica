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
    public partial class PorFecha : Form
    {
        public PorFecha()
        {
            InitializeComponent();
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            foreach (Mascotas aux in Gerente.ListaMascota)
            {
                Fecha f1 = new Fecha(int.Parse(dd1.Text), int.Parse(mm1.Text), int.Parse(aa1.Text));
                Fecha f2 = new Fecha(int.Parse(dd2.Text), int.Parse(mm2.Text), int.Parse(aa2.Text));
                if (aux.Tiene_fecha_entre(f1,f2))
                {
                    foreach (Cliente aux2 in Gerente.ListaCliente)
                    {
                        foreach (Servicio aux3 in aux2.historial)
                        {
                            if (aux3.codigo == aux.Codigo)
                            {
                                listView1.Items.Add(aux3.codigo.ToString()+"  "+aux2.getNombre()+"  "+aux.Nombre);
                            }
                        }
                    }
                }
            }
        }
    }
}
