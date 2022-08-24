//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
             for (int i=0; i<100; i++)//iteración para que cree 100 instancias
            {
                string j = i.ToString();  //creo una variable para crear nuevas intancias
                new Train(j); //creo instancia
            }

            Console.WriteLine($"Existen {Train.Count} instancias de objetos.");

            for (int i=0; i<(10000000); i++) //itero para que cree 10000000 instancias
            {
                string j = i.ToString();
                new Train(j);
            }
            Console.WriteLine($"Existen {Train.Count} instancias de objetos.\n");

            /// Parte 8 y 9
            
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            Console.WriteLine($"t1==t2 tiene el valor bool: {t1==t2}");
            Console.WriteLine($"t2==t3 tiene el valor bool: {t2==t3}");
            
        }
    }
}