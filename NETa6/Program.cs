using NETa6;
using System;
using System.Collections.Generic;

class Program
{

    //static void Main()
    //{
    //    conversor.velocidad = 3.0;
    //    conversor.conversor1();
    //    conversor.conversor2();
    //}
    //    class conversor
    //{
    //    public static double velocidad;

    //    public static void conversor1()
    //    {
    //        velocidad += 20;
    //    }

    //    public static void conversor2()
    //    {
    //        velocidad += 80;
    //    }
    //}

    //static void Main()
    //{
    //    int opcion, repetir = 0;
    //    var con = new conversor();

    //    do
    //    {
    //        Console.WriteLine("intoduzca su tipo de velocidad");
    //        Console.WriteLine(" 1 | kms/s");
    //        Console.WriteLine(" 2 | ms/s");
    //        opcion = Convert.ToInt32(Console.ReadLine());
    //        switch (opcion)
    //        {
    //            case 1: con.conversor1();break;
    //            case 2: con.conversor2(); break;
    //            default:Console.WriteLine("reinte con otro numero pf");break ;
    //        }
    //        Console.WriteLine("para continuar ingrese 1");
    //        repetir = Convert.ToInt32(Console.ReadLine());
    //    } while (repetir == 1 );
    //}        
        
    //class conversor
    //{
    //    private double velocidad;

    //    public void conversor1()
    //    {
    //        Console.WriteLine("Ingrse su velocidad km/h");
    //        velocidad = Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine($"{velocidad} km/s = {velocidad * 3600 / 1000} km/h");
    //    }

    //    public void conversor2()
    //    {
    //        Console.WriteLine("ingrese su velocida ms/s");
    //        velocidad= Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine($"{velocidad} ms/s = {velocidad * 1000 / 36000}");
    //    }

    //}

    static void Main()
    {
        var a1 = new Estudiante() { nombre = "MARIA LUISA SAFRA", edad = 29, dni = 45451111,calificacion=19.63 };                   // creamos variables que sean compatibles con la lista en base a ello le pasamos los valoes segun sus campos de la clase asociada
        var a2 = new Estudiante() { nombre = "NORMA PAIVA", edad = 36, dni = 11111111, calificacion = 12.48};
        var a3 = new Estudiante() { nombre = "HUGO GUTIERREZ", edad = 33, dni = 98765432, calificacion = 13.63 };
        var a4 = new Estudiante() { nombre = "NORMA PURIZACA", edad = 43, dni = 87654321, calificacion = 17.11 };
        var a5 = new Estudiante() { nombre = "FABRIZIO GUTIERREZ", edad = 21, dni = 12345678, calificacion = 15.22 };
        var a6 = new Estudiante() { nombre = "JOAQUIN GUTIERREZ", edad = 23, dni = 45113816, calificacion = 16.55 };

        var school = new School(); // instanciamos el constructor de esa manera hereda sus metodos para ser llamados
        school.addStudents(a1);     // al metodo constructor llamamos sus metodos que tiene disponible y le enviamo al que es de tipo añadir estudiante que recibe un argumento de tiop estudiante y la variable son del tipo estudiante el meotodo tiene el proceso de añadirlo en la lista instanciada de tipo estudiante como tal la variable es compatible con la lista
        school.addStudents(a2);     // aplicamos el metodo ADDSTUDENTS de la clase school que ya fue instanciada en una del mismo nombre
        school.addStudents(a3);
        school.addStudents(a4);
        school.addStudents(a5);
        school.addStudents(a6);

        bool valor = false;

        do
        {
            Console.WriteLine("Ingresa el Dni a buscar");
            int dni = Int32.Parse(Console.ReadLine()); // parsamos el numero de string a int y le pasamos al ametodo que pode un int con el nombre de argumento "dni" este al ingresar al metodo desencadenar todas las tareas las que inlcuye validar y imprimir desde la clase como tal el moeoto pide un argumento en base a ello todo se ejecuta pero tener en cuenta su tipo de ingreso
            valor = school.buscarPorNombre(dni);// ingresa el dni ,metodo devuelveun BOOL como tal el valor final se cambiaria a true ya que se a iniciado con false ver el valor declarado antes del do el bool valor = false
        }
        while (valor); // el VALOR al ser un TRUE termina y esperamos una tecla
        Console.ReadKey(); // funcion que pide una tecla ya que no tiene nada despues termina la ejecucion
    }
}
