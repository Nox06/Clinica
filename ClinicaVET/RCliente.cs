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
    public partial class RCliente : Form
    {
        public RCliente()
        {
            InitializeComponent();
        }

        private void REGISTRAR_Click(object sender, EventArgs e)
        {
            string n = NombreC.Text;
            string a = ApellidoC.Text;
            int ed = int.Parse(EdadC.Text);
            int ID = int.Parse(IDC.Text);
            int c = int.Parse(CodigoC.Text);
            float m = float.Parse(MontoC.Text);

            string nm = NombreM.Text;
            string di = DiagM.Text;
            float pe = float.Parse( PesoM.Text);
            int dd = int.Parse(Dia.Text);
            int me = int.Parse(Mes.Text);
            int aa = int.Parse(Anio.Text);
            string T = Tipo.Text;
            string S = Servicio.Text;


            Gerente.enviar(n,a,ed,ID,c,m,nm,di,pe,dd,me,aa,T);

            NombreC.Text = "";
            ApellidoC.Text = "";
            EdadC.Text = "";
            IDC.Text = "";
            CodigoC.Text = "";
            MontoC.Text = "";


            NombreM.Text = "";
            PesoM.Text = "";
            DiagM.Text = "";
            Dia.Text = "";
            Mes.Text = "";
            Anio.Text = "";
            Tipo.Text = "";
            Servicio.Text = "";

            REGISTRAR.Visible = false;
        }

        public bool es_numero(string n)
        {
            foreach(char c in n)
            {
                if (!(c >='0' && c<='9'))
                {
                    return false;
                }
            }
            return true;
        }

        public bool es_numerof(string n)
        {
            int con = 0;
            foreach (char c in n)
            {
                if (!((c >= '0' && c <= '9') || c=='.'))
                {
                    return false;
                }
                if (c == '.')
                {
                    con++;
                }
                if(con>1)
                {
                    return false ;
                }
            }
            return true;
        }

        public bool Verificar_Codigo(String n)
        {
            foreach(Cliente aux in Gerente.ListaCliente)
            {
                if (aux.Tiene(n))
                    return true;
            }
            return false;
        }

        private void VERIFICAR_Click(object sender, EventArgs e)
        {
            bool b1 = es_numero(EdadC.Text);
            bool b2 = es_numero(IDC.Text);
            bool b3 = es_numero(Dia.Text);
            bool b4 = es_numero(Mes.Text);
            bool b5 = es_numero(Anio.Text);
            bool b6 = es_numerof(PesoM.Text);

            if(b1 && b2 && b3 && b4 && b5 && b6)
            {
                Random aux = new Random();
                String codd;
                int a;


                int aux_tipo;
                String cod = "";
                float costo = 0;
                if(Tipo.Text == "Perro")
                {
                    aux_tipo = 2;
                    cod += "1";
                }
                else
                {
                    if(Tipo.Text == "Gato")
                    {
                        aux_tipo = 3;
                        cod += "2";
                    }
                    else
                    {
                        aux_tipo = 5;
                        cod += "3";
                    }
                }
                if (Servicio.Text == "Consulta")
                {
                    costo = 10 * aux_tipo;
                    cod += "1";
                }
                else
                {
                    if(Servicio.Text == "Spa")
                    {
                        costo = 6 * float.Parse(PesoM.Text);
                        cod += "2";
                    }
                    else
                    {
                        if (Servicio.Text == "Limpieza")
                        {
                            costo = 10;
                            cod += "3";
                        }
                        else
                        {
                            costo = 150;
                            cod += "4";
                        }
                    }
                }
                MontoC.Text = costo.ToString();
                do
                {
                    codd = cod;
                    a = aux.Next(1000, 9999);
                    codd += a.ToString();
                } while (Verificar_Codigo(codd));

                cod = codd;

                CodigoC.Text = cod;

                REGISTRAR.Visible = true;
                label10.Visible = false;
            }
            else
            {
                label10.Text = "Error en la carga de datos";
                label10.ForeColor = Color.Red;
                label10.Visible = true;
            }
        }
    }
}
