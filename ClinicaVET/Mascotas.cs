using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVET
{
    class Mascotas
    {
        private int codigo;
        private string nombre;
        private float peso;
        private string diag;
        private Fecha fecha;
        private String soy;



        public Mascotas()
        {

        }

        public Mascotas(int codigo, string nombre, float peso, string diag, Fecha f)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.peso = peso;
            this.diag = diag;
            this.fecha = f;
            this.soy = "";
        } 

        public bool Tiene_fecha_entre(Fecha f1, Fecha f2)
        {
            if (this.fecha.verifique_si_esta(f1,f2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { this.peso = value; }
        }

        public string Diag
        {
            get { return diag; }
            set { diag = value; }
        }

        public Fecha FEcha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public String Soy
        {
            get { return soy; }
            set { soy = value; }
        }

        public virtual String getRaza()
        {
            return "";
        }
    }
}
