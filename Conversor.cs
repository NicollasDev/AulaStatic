//namespace Aula22Static
//{
    //public static class Conversor
  //  {
      // public static float CotacaoDolar = 5.23f;

       //public static float ConverterDolarParaReal(float valor){
         //  return valor * CotacaoDolar;

      // }
      // public static float ConverterRealParaDolar(float valor){
      //     return valor / CotacaoDolar;
     //  }

   // }
//}

namespace Aula22Static
{
    public static class Conversor
    {
       public static float CotacaoEuro = 5.91f;

       public static float ConverterEuroParaReal(float valorER){
           return valorER * CotacaoEuro;

       }
       public static float ConverterRealParaEuro(float valorRS){
           return valorRS / CotacaoEuro;
       }

    }
}