using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClinicaVET
{
    static class Gerente
    {
        public static List<Cliente> ListaCliente = new List<Cliente>();
        public static List<Mascotas> ListaMascota = new List<Mascotas>();
        public static int op;

        public static void guardar()
        {
            string path = @"C:\Users\yedic\Desktop\ClinicaVET\ClinicaVET\bin\Debug\listaCliente.json";

            string json = JsonSerializer.Serialize(ListaCliente);
            File.WriteAllText(path, json);
        }

        public static void Leer()
        {
            string path = @"C:\Users\yedic\Desktop\ClinicaVET\ClinicaVET\bin\Debug\listaCliente.json";
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IncludeFields = true
            };

            string json = "[{\"nombre\":\"Juan\",\"apellido\":\"Pérez\",\"edad\":30,\"ID\":1}]";
            List<Cliente> clientes1 = JsonSerializer.Deserialize<List<Cliente>>(json, options);


        }

        public static bool verificar(int ID)
        {
            foreach (Cliente aux in ListaCliente)
            {
                if (ID == aux.getID())
                {
                    return true;
                }
            }
            return false;
        }

        public static void insertar(int i, int c, float m, string nm, string di, float pe, int dd, int me, int aa, string T)
        {
            foreach(Cliente aux in ListaCliente)
            {
                if (aux.getID() == i)
                {
                    if (aux.chequear(c) == false)
                    {
                        Servicio nuevoCliente = new Servicio();
                        nuevoCliente.codigo = c;
                        nuevoCliente.monto = (int)m;
                        aux.agregar(nuevoCliente);
                        Mascotas nuevo;

                        if (T == "Perro")
                        {
                            nuevo = new Perro(nm, di, pe, c, new Fecha(dd, me, aa));
                        }
                        else
                        {
                            if(T == "Gato")
                            {
                                nuevo = new Gato(nm, di, pe, c, new Fecha(dd, me, aa));
                            }
                            else
                            {
                                nuevo = new Ave(nm, di, pe, c, new Fecha(dd, me, aa));
                            }
                        }
                        ListaMascota.Add(nuevo);
                    }
                }
            }
        }

        public static void insertar(string n, string a, int e, int i, int c, float m, string nm, string di, float pe, int dd, int me, int aa, string T)
        {
            Cliente C = new Cliente(n,a,e,i);
            C.agregar(new Servicio(c,m));
            ListaCliente.Add(C);
            guardar();

            Mascotas nuevo;

            if (T == "Perro")
            {
                nuevo = new Perro(nm, di, pe, c, new Fecha(dd, me, aa));
            }
            else
            {
                if (T == "Gato")
                {
                    nuevo = new Gato(nm, di, pe, c, new Fecha(dd, me, aa));
                }
                else
                {
                    nuevo = new Ave(nm, di, pe, c, new Fecha(dd, me, aa));
                }
            }
            ListaMascota.Add(nuevo);
        }

        public static void enviar(string n, string a, int e, int ID, int c, float m, string nm, string di, float pe, int dd, int me, int aa, string T)
        {
            if (verificar(ID) == true)
            {
                insertar(ID, c, m,nm,di,pe,dd,me,aa,T);
            }
            else
            {
                insertar(n,a,e,ID,c,m,nm, di, pe, dd, me, aa, T);
            }
        }
    }
}
