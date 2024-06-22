using System;
using System.Collections.Generic;

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

class Program
{
    static void Main(string[] args)
    {
        // Creamos una lista de objetos Juguete
        List<Juguete> juguetes = new List<Juguete>()
        {
            new Juguete(1, "Carro rojo", "rojo"),
            new Juguete(2, "Muñeca azul", "azul"),
            new Juguete(2, "Pelota azul", "azul"),
            new Juguete(3, "45113816", "verde"),
            new Juguete(6, "Camión naranja", "naranja"),
            new Juguete(4, "Dinosaurio amarillo", "amarillo"),
            new Juguete(4, "León amarillo", "amarillo"),
            new Juguete(4, "Pato amarillo", "amarillo"),
            new Juguete(9, "Elefante morado", "morado"),
            new Juguete(5, "Unicornio rosa", "rosa"),
            new Juguete(6, "Tigre naranja", "naranja"),
            new Juguete(5, "Jirafa rosa", "rosa"),
            new Juguete(9, "Mariposa morada", "morado"),
            new Juguete(2, "Robot azul", "azul")
        };

        // Preguntamos al usuario qué juguete busca
        Console.WriteLine("¿Qué juguete buscas?");
        string jugueteBuscado = Console.ReadLine();

        // Creamos una lista auxiliar para almacenar los juguetes únicos
        List<Juguete> list = new List<Juguete>();

        // Recorremos la lista de juguetes
        foreach (Juguete juguete in juguetes)
        {
            int count = 0; // Contador de repeticiones

            // Buscamos el juguete en la lista
            foreach (Juguete jugueteLista in juguetes)
            {
                if (jugueteLista.nombre == juguete.nombre)
                {
                    count++; // Incrementamos el contador de repeticiones
                }
            }

            // Verificamos si el juguete ya está en la lista `list`
            if (numero(juguete.numero, list))
            {
                list.Add(juguete); // Almacenamos el juguete en la lista
            }
        }

        // Mostramos el resultado
        foreach (Juguete jugueteLista in list)
        {
            if (jugueteLista.nombre == jugueteBuscado)
            {

                Console.WriteLine("Color: " + jugueteLista.color); // Mostramos el color
                // ... (Mostrar otras características como material, tamaño, etc.)
            }
        }

        if (!list.Exists(j => j.nombre == jugueteBuscado))
        {
            Console.WriteLine("No se encontró el juguete " + jugueteBuscado);
        }
    }

    static bool numero(int num, List<Juguete> list)
    {
        foreach (Juguete jugueteLista in list)
        {
            if (jugueteLista.numero == num)
            {
                return false;
            }
        }
        return true;
    }
}
