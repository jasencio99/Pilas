using System;
using System.Collections.Generic;
using System.Text;

namespace pilas.Clases.Lista
{
    class ClsEvaluar
    {
        public static double evaluar(String infija)
        {
            String posfija = convertir(infija);
            Console.WriteLine("expresion: " + posfija);
            return evaluarPosfija(posfija);

        }


        private static String convertir(String infija)
        {

            String posfija = "";
            PilaLineal pila = new PilaLineal();


            for (int i = 0; i < infija.Length; i++)
            {

                char letra = infija[i];

                if (esOperador(infija[i]))
                {

                    if (pila.pilaVacia())
                    {
                        pila.insertar(letra);
                    }
                    else
                    {
                        int pe = prioridadEnExpresion(letra);
                        int pp = prioridadEnPila((char)pila.cimaPila());
                        if (pe > pp)
                        {
                            pila.insertar(letra); //apilamos la letra
                        }
                        else
                        {

                            posfija += pila.quitarChar();
                            pila.insertar(letra);
                        }
                    }
                }
                else
                {
                    posfija += letra;
                }
            }

            while (!pila.pilaVacia())
            {
                posfija += pila.quitarChar();
            }
            return posfija;
        }



        //EVALUAR EXPRESION POSFIJA
        private static double evaluarPosfija(String posfija)
        {
            PilaLineal pila = new PilaLineal();

            for (int i = 0; i < posfija.Length; i++)
            {
                char letra = posfija[i];

                if (!esOperador(letra))
                {
                    double num = Convert.ToDouble(letra + "");
                    pila.insertar(num);
                }
                else
                {
                    double num2 = (double)pila.quitarChar();
                    double num1 = (double)pila.quitarChar();
                    double num3 = operacion(letra, num1, num2);
                    pila.insertar(num3);
                }
            }
            return (double)pila.cimaPila();
        }

        private static int prioridadEnExpresion(char operador)
        {

            if (operador == '^') return 4;
            if (operador == '*' || operador == '/') return 2;
            if (operador == '+' || operador == '-') return 1;
            if (operador == '(') return 5;
            return 0;

        }


        private static int prioridadEnPila(char operador)
        {

            if (operador == '^') return 3;
            if (operador == '*' || operador == '/') return 2;
            if (operador == '+' || operador == '-') return 1;
            if (operador == '(') return 0;
            return 0;

        }

        private static bool esOperador(char letra)
        {
            if (letra == '*' || letra == '/' || letra == '+' || letra == '-' || letra == '(' || letra == ')' || letra == '^')
            {
                return true;
            }
            return false;

        }

        private static double operacion(char letra, double num1, double num2)
        {
            if (letra == '*') return num1 * num2;
            if (letra == '/') return num1 / num2;
            if (letra == '+') return num1 + num2;
            if (letra == '-') return num1 - num2;
            if (letra == '^') return Math.Pow(num2, num2);
            return 0;

        }
    }
}
