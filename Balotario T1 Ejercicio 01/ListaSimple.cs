using System;
using System.Collections.Generic;
using System.Text;

namespace Balotario_T1_Ejercicio_01
{
    class ListaSimple
    {
        public Nodo inicio;
        public ListaSimple()
        {
            inicio = null;
        }
        public void Nodos(int valor)
        {
            Nodo nuevoNodo;
            nuevoNodo = new Nodo();
            nuevoNodo.dato = valor;
            nuevoNodo.sgte = inicio;
            inicio = nuevoNodo;
        }
        public void Listar()
        {
            Nodo actual = inicio;
            Console.WriteLine("-------Lista Simple--------");
            while (actual != null)
            {
                Console.Write(actual.dato + " ");
                actual = actual.sgte;
            }
            Console.WriteLine("");
            Console.WriteLine("**************************");
            Console.WriteLine("");
        }
        public int Moda() // calcula la moda de la lista
        {
            if (inicio == null) // si la lista está vacía, no hay moda
            {
                Console.WriteLine("La lista está vacía.");
                return -1;
            }

            Nodo actual = inicio;

            int moda = actual.dato;
            int frecuenciaMaxima = 1;

            while (actual != null) // recorre la lista y encuentra la moda
            {
                int frecuenciaActual = 1;
                Nodo comparar = actual.sgte;

                while (comparar != null) // compara el valor actual con los valores restantes
                {
                    if (actual.dato == comparar.dato)
                    {
                        frecuenciaActual++;
                    }
                    comparar = comparar.sgte;
                }

                if (frecuenciaActual > frecuenciaMaxima || (frecuenciaActual == frecuenciaMaxima && actual.dato > moda))  // actualiza la moda y la frecuencia máxima si se encuentra un valor con mayor frecuencia
                {
                    moda = actual.dato;
                    frecuenciaMaxima = frecuenciaActual;
                }

                actual = actual.sgte;
            }

            if (frecuenciaMaxima == 1) // si la frecuencia máxima es 1, no hay moda
            {
                Console.WriteLine("No hay moda en la lista.");
                return -1;
            }

            Console.WriteLine("La moda de la lista es: " + moda);
            return moda;
        }
    }
}
