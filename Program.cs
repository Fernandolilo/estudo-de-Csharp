class Program
{
    static void Main()
    {
        string nome = "Fernando";
        Console.WriteLine(nome.Length);
        //retorna um booleano se terminar com "e" true ou ! false
        Console.WriteLine(nome.EndsWith("e"));
        //inicia com "F" se sim true, 
        Console.WriteLine(nome.StartsWith("F"));
        Console.WriteLine(nome.Contains("Fernando"));
        //verifica o index de "er" e retorna a posição 1 neste caso como o nome é "Fernando"
        Console.WriteLine(nome.IndexOf("er"));
        //verifica se a string é vazia
        Console.WriteLine(string.IsNullOrEmpty(nome));
        //verifica o dado que esta atribuido a string
        Console.WriteLine(string.IsInterned(nome));
        //verifica se ha espaço vazio na string
        Console.WriteLine(string.IsNullOrWhiteSpace(nome));

        string[] cachorros = { "San", "trix" };
        //faz um join 
        Console.WriteLine(string.Join(" ", cachorros));
        //se retorna a posicao correta vai printar a posicao
        Console.WriteLine("San".CompareTo(cachorros[1]));

        //parse de int para string
        int i = 10;
        int.TryParse("20", out i);
        Console.WriteLine(i);

        //ou 

        int.TryParse("20", out int x);
        Console.WriteLine(x);

    }

}