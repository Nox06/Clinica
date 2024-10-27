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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
            if (Gerente.op == 1)
            {
                int id = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Identificacion"));
                List<String> nomMas = new List<String>();
                bool centinela = false;

                foreach (Cliente cli in Gerente.ListaCliente)
                {
                    if (cli.getID() == id)
                    {
                        centinela = true;
                        foreach (Servicio ser in cli.historial)
                        {
                            foreach (Mascotas mas in Gerente.ListaMascota)
                            {
                                if (ser.codigo == mas.Codigo)
                                {
                                    bool cent = false;
                                    foreach (String n in nomMas)
                                    {
                                        if (n == mas.Nombre)
                                        {
                                            cent = true;
                                        }
                                    }
                                    if (cent == false)
                                    {
                                        nomMas.Add(mas.Nombre);

                                    }
                                }
                            }
                        }
                    }
                }

                if (centinela)
                {
                    this.Text = "Planteamiento3";
                    Titulo.Text = "Lista de Mascotas";
                    foreach (String n in nomMas)
                    {
                        Lista.Items.Add(n);
                    }
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }
            }
            else
            {
                Titulo.Text = "Lista de cliente";
                foreach(Cliente aux in  Gerente.ListaCliente)
                {
                    Lista.Items.Add(aux.getNombre());
                }
            }
            
        }
    }
}
