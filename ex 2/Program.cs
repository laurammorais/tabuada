using System;

namespace ex_2
{
    internal class Program
    {
        static void Main(string[] args)
//            Escreva um programa que leia um número de 1 a 9 e imprima sua respectiva
//tabuada.

       
        {
            float num;
            Console.WriteLine("Digite um numero de 1 a 9");
            num = float.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num,i,num*i);
             
            }

           
        }
}
}
