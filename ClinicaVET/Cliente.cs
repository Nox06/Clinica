using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClinicaVET
{
    class Cliente
    {
       /* private string nombre;
        private string apellido;
        private int edad;
        private int ID;
        public List<Servicio> historial;*/

        [JsonPropertyName("nombre")]
        public string nombre {  get; set; }

        [JsonPropertyName("apellido")]
        public string apellido { get; set; }

        [JsonPropertyName("edad")]
        public int edad { get; set; }

        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("historial")]
        public List<Servicio> historial { get; set; }

        public Cliente(string n, string a, int e, int i)
        {
            this.nombre = n;
            this.apellido = a;
            this.edad = e;
            this.ID = i;
            this.historial = new List<Servicio>();
        }


        public string getNombre()
        {
            return this.nombre;
        }

        public int getID()
        {
            return ID;
        }
        public void agregar(Servicio A)
        {
            this.historial.Add(A);
        }

        public bool chequear(int c)
        {
            foreach (Servicio i in this.historial)
            {
                if (i.codigo == c)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Tiene(String n)
        {
            foreach(Servicio aux in this.historial)
            {
                if (n == aux.codigo.ToString())
                    return true;
            }
            return false;
        }
    }
}
