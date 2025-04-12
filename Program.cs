using System.ComponentModel;

class Program
{
    static void Main()
    {
        int i = 10;
        long x = 520;

        //neste caso se eu quiser igualar   i = x; terei um erro, devido  o int ser menor que um long, mesmo que eu pass I =10 e X=10

        //para que a conversão seja executada terei que fazer a conversao implicita  i = (int)x;

        i = (int)x;

        string s = i.ToString();

        Console.WriteLine(i);
        Console.WriteLine(s);

        //acesso a class test
        Test t = new Test();
        t.x = i;
        Console.WriteLine(t.x);

        int? b = 15;
        //com o operado ? posso atribuir uma variavel null em c#

        b = null;
        //pega o valor default
        Console.WriteLine(b.GetValueOrDefault());
        //posso alterar o default
        Console.WriteLine(b.GetValueOrDefault(2));

        //veja um exemplo 

        //string z = null;
       // Console.WriteLine(z.Length);
        /*
        neste caso vamos ter uma exception um runtime ex.
        Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
   at Program.Main() in D:\.net\estudo\Program.cs:line 38
        */

        //para resolver este problema entra o operador ;

        string? zz = null;
        try
        {
            Console.WriteLine(zz.Length);

        }
        catch (System.NullReferenceException ex)
        {
            Console.WriteLine($"Error, {ex.Message}, {ex.StackTrace}");
        }

    }

}

//teste de acesso a class e inferencia de dados
class Test()
{
    public int x;
}