//using System;

//namespace Aula22Static
//{
   // class Program
   // {
      //  static void Main(string[] args)
       // {
           // Console.ForegroundColor = ConsoleColor.Blue;

          //  Conversor.CotacaoDolar = 5.23f;
           // Console.WriteLine( Conversor.ConverterDolarParaReal(200) );
          //  Console.WriteLine( Conversor.ConverterRealParaDolar(200) );
            
           // Console.ResetColor();


     //   }
  //  }
//}

using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Conversor.CotacaoEuro = 5.91f;
            Console.WriteLine( Conversor.ConverterEuroParaReal(100) );
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( Conversor.ConverterRealParaEuro(100) );
            Console.ResetColor();
           


        }
    }
}
