// See https://aka.ms/new-console-template for more information
using System.Data.Common;

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

if(age >=18) Console.WriteLine("Você é maior de idadae: ");
else if(age == 38) Console.WriteLine($"Você tem {age}");
else Console.WriteLine("voce é menor de idade");
