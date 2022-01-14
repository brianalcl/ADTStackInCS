using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTStack
{
    interface IStack<E>
    {
        /*
         * Retorna el numero de elementos en la pila.
	     */
        int Size();
        /*
         * Si la pila esta vacia retorna verdadero sino retorna falso.
         */
        Boolean IsEmpty();
        /*
         * Retorna el tope de la pila, pero no lo elimina, si la pila esta vacia se lanza una EmptyStackException.
         */
        E Top();
        /*
         * Retorna y elimina el tope de la pila, si la pila esta vaca se lanza una EmptyStackException.
         */
        E Pop();
        /*
         * Coloca un elemento en la pila.
         */
        void Push(E e);
        
    }
}
