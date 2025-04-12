using System.ComponentModel;

class Program
{
    static void Main()
    {
        int[] numbers = { 1 };
        try
        {
            //como tratar este erro por que a popsição do nosso index é 0
            Console.WriteLine(numbers[1]);

        }
        catch (System.NullReferenceException ex)
        {
            Console.WriteLine($"Error, {ex.Message}, {ex.StackTrace}");
        }
        catch (System.IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error, {ex.Message}, {ex.StackTrace}");
        }
        catch (System.Exception ex)
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