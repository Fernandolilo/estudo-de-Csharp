using System.ComponentModel;

class Program
{
    static void Main()
    {
       int i =10;
       long x = 520;

      //neste caso se eu quiser igualar   i = x; terei um erro, devido  o int ser menor que um long, mesmo que eu pass I =10 e X=10

    //para que a conversão seja executada terei que fazer a conversao implicita  i = (int)x;

        i = (int)x;
       
       Console.WriteLine(i);
    }

}