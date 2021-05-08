using pilas.Clases;
using pilas.Clases.Lista;
using System;
using System.Text.RegularExpressions;

namespace pilas
{
    class Program
    {

        static void ejercicio1()
        {
            PilaLineal pila;
            int x;
            int CLAVE = -1;
            Console.WriteLine("Ingrese númros, y para terminar -1");
            try
            {
                pila = new PilaLineal();//crea la pila
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    pila.insertar(x);
                } while (x != CLAVE);

                Console.WriteLine("Estos son los elementos de la pila: ");

                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"elemento: {x}");
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("Error= " + error.Message);
            }
        }


        static void palindromo()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal1;
            String cadena;

            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Introduzca una palabra");
                cadena = Console.ReadLine();
                pal1 = Regex.Replace(cadena, @"\s", "").ToLower();
                String pal = Regex.Replace(pal1.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");

                //creamos la pila con los chars
                for ( int i=0; i< pal.Length;)
                {
                    Char c;
                    c = pal[i++];
                    pilaChar.insertar(c);
                }

                //comprobamos si es palindromo
                esPalindromo = true;
                for(int j=0; esPalindromo&& !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = pal[j++] == c;  //evalúa si la posicion es igual
                }
                pilaChar.LimpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {cadena} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel mi chavo");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }



        static void palindromolista()
        {
            PilaLista pilaChar;
            bool esPalindromo;
            String pal1;
            String cadena;

            try
            {
                pilaChar = new PilaLista();
                Console.WriteLine("Introduzca una palabra");
                cadena = Console.ReadLine();
                pal1 = Regex.Replace(cadena, @"\s", "").ToLower();
                String pal = Regex.Replace(pal1.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");

                //creamos la pila con los chars
                for (int i = 0; i < pal.Length;)
                {
                    Char c;
                    c = pal[i++];
                    pilaChar.insertar(c);
                }

                //comprobamos si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitar();
                    esPalindromo = pal[j++] == c;  //evalúa si la posicion es igual
                }
                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {cadena} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel mi chavo");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }


        static void EjemploLista()
        {
            int x;
            ListaSimple lista1 = new ListaSimple();
            //PilaLista pilaLista = new PilaLista();
            //PilaLineal pilaLineal = new PilaLineal();

            lista1.InsertarList(4);
            lista1.InsertarList(5);
            lista1.InsertarList(12);
            lista1.InsertarList(28);
            lista1.InsertarList(0);
            lista1.InsertarList(5);

            lista1.Pilainversa();

        }

        static void Evaluacion()
        {
            string infija;
            Console.WriteLine("INGRESE EL MODELO MATEMATICO");
            infija = Console.ReadLine();

            Console.WriteLine("RESPUESTA: " + ClsEvaluar.evaluar(infija));
        }

        static void Main(string[] args)
        {
            //ejercicio1();
            //palindromo();
            //EjemploLista();
            Evaluacion();
        }
    }
}
