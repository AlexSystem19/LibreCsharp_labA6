using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETa6
{
    public class School
    {
        private List<Estudiante> students;

        public School()
        {
            students = new List<Estudiante>();                // instanciamos la lista de tipo ESTUDIANTE (clase de 4 propiedades) en un variable de nombre STUDENTS.
        }

        

        //añadir estudiante a la lista STUDENT de tipo ESTUDIANTE

        public void addStudents(Estudiante nuevoestudiante)   // creamos un metodo que pida un argumento de tipo Estudiante y de nombre Nuevo_estudiante
        {
            students.Add(nuevoestudiante);                    // a la instancia de la lista de tipo Estudiante aplicamos la funcion ADD y como pide un valor le pasamos el argumento del metodo
        }


        //buscar estudiante

        public bool buscarPorNombre(int dni)               //cremmos un metodo de tipo BOOL que pida un argumento de tipo string de nombre NAME
        {
            bool encontrado = false;                           // declaramos variables en false que servira para terminar el do while
            int i = 0;                                         // contado para avanzar en la lista que se tiene instanciada en STUDENTS

            while (encontrado == false && i < students.Count)
            {
                if (students[i].dni.Equals(dni))
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
                if(encontrado)
                {
                    Console.WriteLine("Nombre :" + students[i].nombre+"\n"
                        +"Edad :" + students[i].edad+"\n"
                        +"Dni : "+ students[i].dni+"\n"
                        +"Calificacion : " + students[i].calificacion);
                    return true;
                }
                else
                {
                    Console.WriteLine("No se encontro estudiante, reintente");
                    return true;
                }
            }
        }
    }

