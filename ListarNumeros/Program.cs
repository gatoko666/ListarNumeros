using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Escribir un método que acepte una lista con números y devuelva dicha lista en orden invertido.Ejemplo: Si ingresamos la lista { 4,6,49}, 
//entonces el método debe devolver la lista {49,6,4}

namespace ListarNumeros
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la cantidad de números de su lista :  ");
            int numero = int.Parse(Console.ReadLine());

            // Crear vector con tamaño que se ha asignado
            string[] soyUnVector = new string[numero];

            //llenarlo

            for (int i =0;i<numero;i++)
            {
                Console.Write("Números  {0}: ", i);
                soyUnVector[i] = Console.ReadLine();
            }






            //imprimir
            Console.WriteLine(" \nValores del vector:\n");
            for (int i =0;i<numero;i++)
            {
                Console.WriteLine("Posicion {0}: {1}", i, soyUnVector[i]);
            }
            

            ///////////////////////////////////////////


            //calcular tamaño de array
            int length = soyUnVector.Length;

            //ordenar array inverso

            Array.Reverse(soyUnVector);

            //imprimir
            Console.WriteLine("\nArray invertido:\n");

            for (int i=0;i<length;i++)
            {
                Console.WriteLine(soyUnVector[i]);
            }
            Console.ReadKey();


        }
    }
}
