using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETa6
{
    class Tanque
    {
        //campos privados que serviran como plantilla para la informacion que se va a solicitar y o procesar segun el tipo
        private string nombre_tanque;
        private string pais_tanque;
        private int año_tanque;
        

        //Constructor de la clase principal el cual pide 3  valores y o argumentos estos se igualan a los campos los cuales ya tienen una propiedad
        //privada para cada argumento solicitado en el constructor.
        public Tanque(string nombreT, string paisT, int añoT)
        {
           nombre_tanque = nombreT;
           pais_tanque = paisT;
           año_tanque = añoT;
        }


        /*Propiedades publicas que permiten la manipulacion de los datos que son los campos que se van a trabajar en las siguientes funciones*/
        public string NombreP { get => nombre_tanque; set => nombre_tanque = value; }
        public string PaisP { get => pais_tanque; set => pais_tanque = value; }
        public int añoP { get => año_tanque; set => año_tanque = value; }


        //metodo que imprime informacion del tanque en consulta
        public void informacion()
        {
            Console.WriteLine("Tanque : " + NombreP + " del pais : " + PaisP + " y del año : " + añoP);
        }

        //metodo para simular batalla
        public void Batalla(int fuerzaTanqueLocal, Tanque enemigo, int fuerzaEnemigo)
        {
            Console.WriteLine($"{NombreP} de {PaisP} esta batallando contra {enemigo.NombreP}");

            if(fuerzaTanqueLocal<fuerzaEnemigo)
            {
                Console.WriteLine($"{enemigo.NombreP} gana demostrando superioridad y conquista su reino");
            }
            else if(fuerzaTanqueLocal>fuerzaEnemigo)
            {
                Console.WriteLine($"{NombreP} gana demostrando superioridad en su reino");
            }
            else
            {
                Console.WriteLine("Es un Empate de fuerza de armamentos!");
            }
        }
    }


}
