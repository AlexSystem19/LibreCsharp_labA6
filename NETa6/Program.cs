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

    static void Main()
    {
        int opcion, repetir = 0;
        var con = new conversor();

        do
        {
            Console.WriteLine("intoduzca su tipo de velocidad");
            Console.WriteLine(" 1 | kms/s");
            Console.WriteLine(" 2 | ms/s");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1: con.conversor1();break;
                case 2: con.conversor2(); break;
                default:Console.WriteLine("reinte con otro numero pf");break ;
            }
            Console.WriteLine("para continuar ingrese 1");
            repetir = Convert.ToInt32(Console.ReadLine());
        } while (repetir == 1 );
    }        
        
    class conversor
    {
        private double velocidad;

        public void conversor1()
        {
            Console.WriteLine("Ingrse su velocidad km/h");
            velocidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{velocidad} km/s = {velocidad * 3600 / 1000} km/h");
        }

        public void conversor2()
        {
            Console.WriteLine("ingrese su velocida ms/s");
            velocidad= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{velocidad} ms/s = {velocidad * 1000 / 36000}");
        }

    }


}
