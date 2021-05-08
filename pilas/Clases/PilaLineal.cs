using System;
using System.Collections.Generic;
using System.Text;

namespace pilas.Clases
{
    class PilaLineal
    {
        private static int TAMPILA = 49;
        private int cima;
        private Object[] ListaPila;

        public PilaLineal()
        {
            cima = -1;//condición de pila vacía.
            ListaPila = new Object[TAMPILA];
        }

        public bool pilallena()
        {
            return cima == (TAMPILA - 1);
        }

        public void insertar (Object elemento)
        {
            if (pilallena())
            {
                throw new Exception("Desbordamiento de pila Stack Overflow");
            }
            //incremanar puntero y vamos a insertar el elemento
            cima++;
            ListaPila[cima] = elemento;
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }

        //retorna un tipo char

        public Object quitarChar()
        {
            Object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia, no hay data");
            }
            aux = (Object)ListaPila[cima];
            cima--;
            return aux;
        }

        public Object quitar()
        {
            int aux;
            if (pilaVacia())
            {
                throw new Exception("La pila está vacía, no se puede sacar");
            }
            //guardar el elemento en la cima
            aux = (int)ListaPila[cima];
            //decrementar el valor de cima y retornar elemento
            cima--;
            return aux;
        }

        public void LimpiarPila()
        {
            cima = -1;
        }

        //operacion de acceso a la pila
        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("pila vacia");
            }
            return ListaPila[cima];
        }
    }
}
