using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicioDeProgramacion
{
    class Program
    {
        public static bool Palindromo(string arg)
        {
            bool valor = true;
            int p = 0;
            char[] caracter = new char[arg.Length];
            foreach (char c in arg)
            {
                caracter[p] = c;
                p++;
            }
            foreach (char c in arg)
            {
                p--;
                if (c == caracter[p])
                {
                    valor = true;
                }
                else
                {
                    valor = false;
                    return valor;
                }

            }
            return valor;
        }


        public static int Repetir(string argumento, string parte)
        {

            int a = 0;
            int b = 0;


            string[] words = argumento.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[a] == parte)
                {
                    a++;
                    b++;
                    Console.WriteLine(a);
                    b = 0;


                }
            }
            return a;



        }




        static void Main(string[] arg)
        {
            int menu = 0;
            string seleccion = "";
            string palindromo = "";
            while (menu == 0)
            {
                Console.Clear();
                Console.WriteLine("A. Palindromo ");
                Console.WriteLine("B. Repeticion (aun sin ninguna entrada) ");
                Console.WriteLine("C. Salir ");
                seleccion = Console.ReadLine();
                if (seleccion != "1,2, 3")

                    switch (seleccion)
                    {
                        case ("A"):
                            Console.Clear();
                            Console.WriteLine("Digite la palabra a comparar en el campo siguiente|                         k ");
                            palindromo = Console.ReadLine();
                            bool texto = Palindromo(palindromo);
                            if (texto == true)
                            {
                                Console.WriteLine("La palabra es palindromo ");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("La palabra no es palindromo ");
                                Console.ReadLine();
                            }
                            break;

                        case ("B"):

                            Console.Clear();
                            int repeticion = 0;
                            string valor1 = "";
                            string valor2 = "";

                            Console.WriteLine("escriba un texto a comparar");
                            valor1 = Console.ReadLine();
                            Console.WriteLine("escriba la palabra, oracion o etc que desea saber cuantas veces se repitio");
                            valor2 = Console.ReadLine();
                            repeticion = Repetir(valor1, valor2);
                            Console.WriteLine("el valor " + valor1 + "se logro repetir  " + repeticion + " veces");
                            Console.WriteLine("ojo, solo  " + repeticion);
                            Console.ReadLine();


                            break;

                        case ("C"):

                            menu = 1;

                            break;
                    }
                else
                {
                    Console.WriteLine("no selecciono nada");
                    Console.Clear();
                }

            }
        }

        
    }
}

