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
    public partial class planteamiento1 : Form
    {
        public planteamiento1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float suma = 0;
            foreach(Mascotas aux in Gerente.ListaMascota)
            {
                if (textBox1.Text == aux.FEcha.dia.ToString() && textBox2.Text == aux.FEcha.mes.ToString() && textBox3.Text == aux.FEcha.anio.ToString())
                {
                    foreach(Cliente aux1 in Gerente.ListaCliente)
                    {
                        foreach(Servicio aux2 in aux1.historial)
                        {
                            if (aux2.codigo == aux.Codigo)
                            {
                                suma += aux2.monto;
                            }
                        }
                    }
                }
            }

            label1.Text = suma.ToString();
        }
    }
}
