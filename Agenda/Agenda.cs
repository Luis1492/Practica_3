using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        Contactos[] contactos = new Contactos[15];
        public int contador = 0;
        public int total = 14;
        public void Agregar(Contactos info)
        {
            contactos[contador] = info;
            contador++;
            
        }

        public Contactos Buscar(string tel)
        {
            for(int b=0; b<total; b++)
            {
                if(contactos[b].Telefono  == tel)
                {
                    return contactos[b] ;
                }
            }
            return null;
        }

        public void Eliminar(Contactos info)
        {
            for(int e=0; e<total-1; e++)
            {
                if(contactos[e] == info)
                {
                    contactos[e] = contactos[e+1];
                    
                }  
            }
            contactos[contador-1] = null;
            contador--;
        }

        public void Insertar(Contactos info, int posi)
        {
            for (int i = 0; i <= total; i++)
            {
                contactos[posi] = contactos[posi + 1];
                contactos[posi] = info;
            }
            contador++;
        }

        public string Listar()
        {
            string cadena = " ";
            for(int m=0; m < contador; m++)
            {
                cadena += contactos[m].Nombre + " " + contactos[m].Appaterno + " " +  contactos[m].Apmaterno + Environment.NewLine + contactos[m].Telefono + Environment.NewLine + contactos[m].Edad + Environment.NewLine + contactos[m].Email + Environment.NewLine;
            }
            return cadena;
        }
    }
}
