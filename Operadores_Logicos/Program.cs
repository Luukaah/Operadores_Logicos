using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // && = E ;
            // || = OU;
            // ! = NO ;
            // APENAS SERA CONSIDERADO VERDADEIRO , SE AS DUAS CONDIÇÕES FOREM VERDADEIRAS ; 

            bool c1 = 4 != 5; //  DIFERENTE = VERDADEIRO ;
            bool c2 = 2 > 3 && 4 != 5; // DUAS CONDIÇÕES , FALSE E TRUE = FALSE ;

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            // PELO MENOS UM RESULTADO DEVE SER VERDADEIRO ;
            // OPERADOR OU ; SE CUMPRIR UM REQUISITO, SERA VERDADEIRO ;

            bool c3 = 2 > 3 || 4 != 5; // VERDADEIRO ;
            Console.WriteLine(c3); // TRUE ;
            // PRECEDENCIA , !> && > || ;

            bool c4 = !(2 < 3) && 4 != 5; // || = NEGA A INFORMAÇÃO, SE FOR POSITIVO ELE INVERTE O RESULTADO E VICE VERSA ;
            Console.WriteLine(c4);
            Console.WriteLine("____________________");

            bool c5 = 10 < 5;
            bool c6 = c3 || c4 && c4;
            Console.WriteLine(c5); // FALSE ;
            Console.WriteLine(c6);// TRUE ;

        }
    }
}
