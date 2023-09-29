using System;

namespace Balotario_T1_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaSimple lista = new ListaSimple();
            Random R = new Random();

            Console.Write("Ingrese una cantidad de numeros: ");
            int cant = int.Parse(Console.ReadLine());

            for (int i = 0; i < cant; i++)
            {
                lista.Nodos(R.Next(0, 100));
            }

            lista.Listar();
            lista.Moda();

        }
    }
}
