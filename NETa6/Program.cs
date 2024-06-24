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

        var data1 = new conversor();
        data1.velocidad = 5.0;
        data1.conversor1();
    
        var data2 = new conversor();
        data2.conversor2();

        

    }
    class conversor
    {
        public double velocidad;

        public void conversor1()
        {
            velocidad += 20;
        }

        public void conversor2()
        {
            velocidad += 80;
        }
    }


}
