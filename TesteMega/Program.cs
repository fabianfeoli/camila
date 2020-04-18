using System;
using MegaSena1;

namespace TesteMega
{
    class Program
    {
        static void Main(string[] args)
        {
            SorteioRepositorio rep = new SorteioRepositorio();
            rep.CarregarDoArquivo(@"c:\temp\d_mega.htm");
          
            Console.ReadKey();



        }
    }
}
