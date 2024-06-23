using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETa6
{
    class Juguete
    {
        public int numero;
        public string nombre;
        public string color;
        // ... (puedes agregar otras características como material, tamaño, etc.)

        public Juguete(int numero, string nombre, string color)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.color = color;
        }
    }
}
