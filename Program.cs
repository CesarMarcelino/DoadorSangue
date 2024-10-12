int idade;
Console.Write("Qual a sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18 && idade <= 67)
{
   Console.ForegroundColor = ConsoleColor.Green;
   Console.WriteLine("Você pode ser doador de sangue.");
   Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você não pode ser doador de sangue.");
    Console.ResetColor();
}