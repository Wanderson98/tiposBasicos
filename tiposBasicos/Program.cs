using System;
using System.Globalization;

namespace tiposBasicos {
    class Program {
        static void Main(string[] args) {
            bool completo = true;
            char genero = 'M';
            char letra = '\u0041';
            byte n1 = 96;
            int n2 = 900;
            int n3 = 2141253647;
            long n4 = 2147985648L;
            float n5 = 2.5f;
            double x = 215.143234;
            int z = int.MaxValue;
            String nome = "Joana Lins";
            Object obj1 = "Bruno Farias";
            Object obj2 = 4.5f;


            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(x);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(z);
            //saida de dados 

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F4", CultureInfo.InvariantCulture)) ;

            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");


            int idade = 32;
            String name = "Maria";
            double saldo = 234.1423;

            Console.WriteLine("{0} tem {1} anos e R$ {2} de saldo", name, idade, saldo);
            Console.WriteLine("{0} tem {1} anos e R$ {2:F2} de saldo", name, idade, saldo);
            Console.WriteLine($"{name} tem {idade} anos e R$ {saldo:F2} de saldo ");
        }
    }
}
