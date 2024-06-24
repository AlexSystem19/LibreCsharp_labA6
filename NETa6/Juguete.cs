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
//static void Main(string[] args)
    //{
    //    // Creamos una lista de objetos Juguete
    //    List<Juguete> juguetes = new List<Juguete>()
    //    {
    //        new Juguete(1, "Carro rojo", "rojo"),
    //        new Juguete(2, "Muñeca azul", "azul"),
    //        new Juguete(2, "45113816", "azul"),
    //        new Juguete(3, "Oso verde", "verde"),
    //        new Juguete(6, "Camión naranja", "naranja"),
    //        new Juguete(4, "Dinosaurio amarillo", "amarillo"),
    //        new Juguete(4, "León amarillo", "amarillo"),
    //        new Juguete(4, "Pato amarillo", "amarillo"),
    //        new Juguete(9, "Elefante morado", "morado"),
    //        new Juguete(5, "Unicornio rosa", "rosa"),
    //        new Juguete(6, "Tigre naranja", "naranja"),
    //        new Juguete(5, "Jirafa rosa", "rosa"),
    //        new Juguete(9, "Mariposa morada", "morado"),
    //        new Juguete(2, "Robot azul", "azul")
    //    };

//    // Preguntamos al usuario qué juguete busca
//    Console.WriteLine("¿Qué juguete buscas?");
//    string jugueteBuscado = Console.ReadLine();

//    // Recorremos la lista de juguetes
//    foreach (Juguete juguete in juguetes)
//    {
//        if (juguete.nombre == jugueteBuscado)
//        {
//            Console.WriteLine("¡Se encontró el " + juguete.nombre + "!");
//            Console.WriteLine("Color: " + juguete.color); // Mostramos el color
//            // ... (Mostrar otras características como material, tamaño, etc.)
//            return; // Salimos del bucle si se encuentra el juguete
//        }
//    }

//    // Si no se encuentra el juguete, mostramos un mensaje
//    Console.WriteLine("No se encontró el juguete " + jugueteBuscado);

//    /* T A N Q U E */

//    //Crear objetos de la clase tanque

//    Tanque t1q = new Tanque("TQX-1905", "UCRANIA", 2028);
//    Tanque t2q = new Tanque("TRQ-1115", "SUECIA", 2018);
//    Tanque t3q = new Tanque("TQX-1900", "ALBANIA", 2018);
//    Tanque t4q = new Tanque("TQX-1906", "NORUEGA", 2008);
//    Tanque t5q = new Tanque("TQX-6565", "BRASIL", 2018);
//    Tanque t6q = new Tanque("TQQ-115", "PERU", 2021);
//    Tanque t7q = new Tanque("RQX-8888", "CUBA", 2020);
//    Tanque t8q = new Tanque("ZZS-369", "ARGENTINA", 2008);
//    Tanque t9q = new Tanque("T12-ASW", "BOLIVIA", 2021);

//    //modificando datos

//    t6q.PaisP = "EEUU";
//    t6q.NombreP = "ZED";

//    //imprime infomracion de algunos tanques

//    t1q.informacion();
//    t3q.informacion();
//    t6q.informacion();
//    t9q.informacion();

//    //simulacion de batalla

//            t1q.Batalla(89, t6q, 80);

//    t1q.cambiarnacionalidad(t1q);
//    t1q.informacion();




//    conversora6.Velocidad = 3.0;
//    Console.WriteLine(conversora6.Velocidad);
//    Console.ReadKey();
//}

//class conversora6
//{
//    public static double Velocidad;
//}
