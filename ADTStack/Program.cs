using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTStack
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Se asume que los datos ingresados son validos");
                Console.WriteLine("Coloque una opcion: ");
                Console.WriteLine("1) Testeo basico");
                Console.WriteLine("2) Voltear cadena");

                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        BasicTest();
                        break;
                    case 2:
                        VoltearCadena();
                        break;
                }
                Console.ReadLine();

            }
            catch (EmptyStackException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        static void VoltearCadena()
        {
            IStack<char> pila = new LinkedStack<char>();
            char c = '0';
            Console.WriteLine("Coloque una cadena caracteres, al terminar presione ENTER");

            while(c != 13)
            {
                c = (char)Console.Read();
                pila.Push(c);
            }

            Console.WriteLine("Cadena volteada: ");
            while (!pila.IsEmpty())
            {
                Console.Write(pila.Pop());
            }
        }
        static void BasicTest()
        {
            IStack<char> pila = new LinkedStack<char>();

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Veamos el tamaño de la pila inicial: ");
            Console.WriteLine("pila.Size(): " + pila.Size());
            Console.WriteLine("pila.IsEmpty(): " + pila.IsEmpty());
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Colocamos a b c d e con pila.Push(elem) y en cada caso vemos el size");

            for (char c = 'a'; c <= 'e'; c++)
            {
                pila.Push(c);
                Console.WriteLine("pila.Size() con {0}: {1} ", c, pila.Size());
            }

            Console.WriteLine("pila.IsEmpty(): " + pila.IsEmpty());
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Veamos cual es el elemento en el tope de la pila sin sacarlo");
            try
            {
                Console.WriteLine("pila.Top(): " + pila.Top());
                Console.WriteLine("pila.Size(): " + pila.Size());
            }
            catch (EmptyStackException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Mientras la pila no este vacia sacamos elementos uno a uno");
            Console.WriteLine("pila.IsEmpty(): " + pila.IsEmpty());
            while (!pila.IsEmpty())
            {
                Console.WriteLine("pila.Size(): {0}, pila.Pop(): {1}", pila.Size(), pila.Pop());
            }
            Console.WriteLine("pila.Size(): " + pila.Size());
            Console.WriteLine("pila.IsEmpty(): " + pila.IsEmpty());
            Console.WriteLine("--------------------------------------------------------------------------------");

        }
    }

}
