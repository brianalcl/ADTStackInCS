using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTStack
{
    class LinkedStack<E> : IStack<E>
    {
        protected Node<E> head;
        protected int size;

        public LinkedStack()
        {
            head = null;
            size = 0;
        }


        public E Pop()
        {
            E aux;
            if (head == null)
                throw new EmptyStackException("Error: no se puede sacar el primer elemento de una pila VACIA");
            aux = head.GetElement();
            head = head.GetNext();
            size--;
            return aux;
        }        
        public E Top()
        {
            E aux;
            if (head == null)
                throw new EmptyStackException("Error: no se puede mostrar el primer elemento de una pila vacia");
            aux = head.GetElement();
            return aux;
        }

        public void Push(E e)
        {
            Node<E> aux = new Node<E>();
            aux.SetElement(e);
            aux.SetNext(head);
            head = aux;
            size++;
        }

        public int Size()
        {
            return size;
        }
        public bool IsEmpty()
        {
            return head == null;
        }
    }

}
