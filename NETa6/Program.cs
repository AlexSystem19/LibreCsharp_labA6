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
            new Juguete(3, "Oso verde", "verde"),
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

        // Recorremos la lista de juguetes
        foreach (Juguete juguete in juguetes)
        {
            if (juguete.nombre == jugueteBuscado)
            {
                Console.WriteLine("¡Se encontró el " + juguete.nombre + "!");
                Console.WriteLine("Color: " + juguete.color); // Mostramos el color
                // ... (Mostrar otras características como material, tamaño, etc.)
                return; // Salimos del bucle si se encuentra el juguete
            }
        }

        // Si no se encuentra el juguete, mostramos un mensaje
        Console.WriteLine("No se encontró el juguete " + jugueteBuscado);
    }
}
