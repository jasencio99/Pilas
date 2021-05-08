using System;
using System.Collections.Generic;
using System.Text;

namespace pilas.Clases.Lista
{
    class ListaSimple
    {
        public Nodo primero;
        int cima;

        //CONSTRUCTOR
        public ListaSimple()
        {
            primero = null;

        }

        //INSERTAR 
        public void InsertarList(object dato)
        {

            Nodo nuevo = new Nodo(dato);

            if (ListaVacia())
            {
                primero = nuevo;
            }
            else
            {
                nuevo.enlace = primero;
                primero = nuevo;
            }
            cima++;
        }

        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }


        public void Pilainversa()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                actual = actual.enlace;
            }
        }


        //ELIMINAR EN EL PALINDROMO 
        public object quitarChar()
        {
            char aux;

            if (ListaVacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            else
            {
                aux = (char)primero.dato;
                primero = primero.enlace;

                cima--;
                return aux;
            }

        }

        public void LimpiarPila()
        {
            cima = -1;

        }



        public object quitar()
        {
            int aux;
            if (ListaVacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (int)primero.dato;
            primero = primero.enlace;
            cima--;
            return aux;
        }
    }
}
