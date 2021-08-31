//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections;
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
            Console.WriteLine("Hello World!");
            ArrayList ArrayDeTrenes = new ArrayList();
            for (int i=0; i<100; i++)
            {
                ArrayDeTrenes.Add(new Train(i.ToString()));
            }
            
        }
    }
}