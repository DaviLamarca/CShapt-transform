using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char gereno = 'F'; // um unico caracter
            bool t1 = true; // True or false
            sbyte n1 = -1; // Pode ser tanto negativo quanto posítivo, 127/-128
            int n2 = 2147483647; // Esse é o maximo que ele aguenta
            long n3 = 2147483648L; // Aguenta muito mais.
            float n4 = 4.5f; //Numeros flutuantes
            double n5 = 4.5; // Aguenta mais numeros
            string nome = "Davi"; // depoisn de declarado, não se pode mais mudar
            object obj1 = "show"; //aceita qualquer valor
            object obj2 = "de bola";
            
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(nome);
            Console.WriteLine(gereno);
            Console.WriteLine(n5);
            Console.WriteLine(n4);
            Console.WriteLine(t1);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            int minimoInt = Int32.MaxValue;
            Console.WriteLine(minimoInt);

            decimal maximo = decimal.MaxValue;
            
            Console.WriteLine(maximo);
        }
    }
}