using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,res,i=1;
            Console.WriteLine("Tabuada\n\n");
            Console.WriteLine("Digite um número e veja a tabuada deste:");
            numero = Convert.ToInt32(Console.ReadLine());

            while (i <= 10)
            {

                res = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero.ToString(), i.ToString(), res.ToString());
                i++;


            }
        }
    }
}
