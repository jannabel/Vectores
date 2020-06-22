using System;

namespace ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jannabel Ramos Ramirez  MAT. 2019-8510   

            //Ejercicio_1();
            //Ejercicio_2();
            //Ejercicio_3();
            //Ejercicio_4();
            //Ejercicio_5();
            //Ejercicio_6();
            //Ejercicio_7();
            Console.Write(" \n ");
            Console.Write(" \n ");
        }

        static void  Ejercicio_1()
        {
            /*1. Un programa que pida al usuario 4 números, los memorice(utilizando una tabla), 
            calcule su media aritmética y después muestre en pantalla la media y los datos tecleados*/
       
            int[] numeros = new int[4];
            double suma=0, media;

            for (int i = 0; i < 4; i++)
            {
                Console.Write(" ~ ~ Ingrese un numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];             
            }
            Console.Clear();

            Console.Write(" ~ ~ Los numeros ingresados son: ");
            for (int n = 0; n < 4; n++)
            {
                Console.Write("   "+numeros[n]);
            }
            media = suma / 4;
            Console.Write("\n ~ ~ La media es: " + media);
        }
     


        static void Ejercicio_2() 
        {
            /*2. Un programa que pida al usuario 5 números reales(pista: necesitarás un array de "float")
              y luego los muestre en el orden contrario al que se introdujeron. */

            int[] numeros = new int[6];

            for (int i = 0; i < 5; i++)
            {
                Console.Write(" ~ ~ Ingrese un numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            for (int n = 4; n >= 0; n--)
            {
                Console.WriteLine("~ " + numeros[n]);
            }
        }

        static void Ejercicio_3()
        {

            /*3. Un programa que almacene los días de la semana en un array y luego mostrarlo.*/
            string[] semana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };


            foreach (var dias in semana)
            {
                Console.WriteLine(" ~ "+dias);
            }


        }

        static void Ejercicio_4()
        {
            /*4. Un programa que almacene en una tabla el número de días que tiene cada mes
              (supondremos que es un año no bisiesto), pida al usuario que le indique un mes
              (1 = enero, 12 = diciembre) y muestre en pantalla el número de días que tiene ese mes.*/

           

            int[] meses = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            

            Console.Write(" ~ Ingrese un mes: ");            
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write(" El mes {0} tiene {1} dias: ",m, meses[m]);

        }

        static void Ejercicio_5()
        {

            /*5. Un programa que almacene en una tabla el número de días que
            tiene cada mes(de un año no bisiesto), pida al usuario que le 
            indique un mes(ej. 2 para febrero) y un día(ej.el día 15)
            y diga qué número de día es dentro del año
           (por ejemplo, el 15 de febrero sería el día número 46, el 31
            de diciembre sería el día 365).*/

            int[] meses = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.Write("\n ~ Ingrese un mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.Write(" ~ Ingrese un dia: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            int contador = 0, i = 0;

            for (i = 1; i <= mes; i++)
            {                                         
                contador += meses[i - 1]; 
            }


            int total_de_dias=contador + dias; 
            
            Console.WriteLine("\n ~ El dia es:  "+ total_de_dias);
        }

        static void Ejercicio_6()
        {

            /*6.Crear un programa que pida al usuario la fecha, 
               detallando el día (1 al 31) y el mes (1=enero, 12=diciembre), 
               luego muestre en pantalla el número de días que quedan hasta final 
               de año.*/

            int[] meses = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.Write("\n ~ Ingrese un mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.Write(" ~ Ingrese un dia: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            int contador = 0, i = 0;

            for (i = 1; i <= mes; i++)
            {
                contador += meses[i - 1];
            }
            int c = 0;

            for (int j = 1; j <= 12; j++)
            {
                c += meses[j];
            }

            int total_de_dias = contador + dias;
            int dias_restantes = c - total_de_dias ;

            Console.WriteLine("\n ~ Quedan {0} dias: ", dias_restantes);
        }

        static void Ejercicio_7()
        {

            /* 7. Un programa que pida al usuario 10 números, 
             calcule su media y luego muestre los que están por encima de la media.*/
            int[] numeros = new int[11];

            double suma = 0, media;

            for (int i = 0; i < 10; i++)
            {
                Console.Write(" ~ ~ Ingrese un numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }
            Console.Clear();
            media = suma / 10;

            Console.WriteLine("\n ~ ~ La media es: " + media);
            Console.WriteLine(" ~ ~ Los numeros por encima de la media son: ");

            for (int n = 0; n < 10; n++)
            {
                if(numeros[n]>media) Console.WriteLine(" ~ "+numeros[n]);
            }            
        }
    }
}
