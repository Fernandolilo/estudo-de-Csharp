// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//um ex usando o console para escrita.
Console.Write("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine(name);
Console.WriteLine($"Olá {name}");
Console.Write("Digite o ano de nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = 2025 - year;
Console.WriteLine($"idade: {age}");