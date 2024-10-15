// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;




string[] vowels = new string[] { "a", "e", "i", "o", "u" };
Console.WriteLine("type smth");
String userinput = Console.ReadLine();
int vowelcount = 0;
for (int i = 0; i < userinput.Length; i++)
{
    if (vowels.Contains(userinput[i].ToString()))
    {
        vowelcount++;
    }
}

Console.WriteLine("The text you entered contains" + " " + vowelcount + " " + "vowels");
Console.WriteLine("-----------------------------------------");

Console.WriteLine("Enter any number");
int userinput1 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < 11; i++)
{
    int multanswer = userinput1 * i;
    Console.WriteLine($" {userinput1}X{i} = {multanswer}");

}

Console.WriteLine("-----------------------------------------");
string[,] matrix1 = new string[3, 3];
string[,] matrix2 = new string[3, 3];
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Console.WriteLine($"enter numbers for ({x},{y}) point of your first 3X3 matrix");
        matrix1[x, y] = Console.ReadLine();

    }
}

Console.WriteLine("here is your matrix ");
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Console.Write(matrix1[x, y] + "\t");
    }
    Console.WriteLine();

}
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Console.WriteLine($"enter numbers for ({x},{y}) point of your second 3X3 matrix");
        matrix2[x, y] = Console.ReadLine();

    }
}

Console.WriteLine("here is your matrix ");
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Console.Write(matrix2[x, y] + "\t");
    }
    Console.WriteLine();

}
Console.WriteLine("this is the sum ");
Console.WriteLine();
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        int k = Convert.ToInt32(matrix1[x, y])  + Convert.ToInt32(matrix2[x, y] );

        Console.Write(k + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("-----------------------------------------");

Console.Write($"Calculator Menu: \n 1) Addition \n 2) Subtraction \n  3) Multiplication \n 4) Division \n  5) Exit");
Console.WriteLine("choose an option");
string userinput3 = Console.ReadLine();


if (userinput3 == "1")
{
    Console.WriteLine("enter first number");
    string l = Console.ReadLine();
    Console.WriteLine("enter second number");
    string v = Console.ReadLine();
    decimal f = Convert.ToDecimal(l) + Convert.ToDecimal(v);
    Console.WriteLine($"{l}+{v}={f}");

}
if (userinput3 == "2")
{
    Console.WriteLine("enter first number");
    string l = Console.ReadLine();
    Console.WriteLine("enter second number");
    string v = Console.ReadLine();
    decimal f = Convert.ToDecimal(l) - Convert.ToDecimal(v);
    Console.WriteLine($"{l}-{v}={f}");
}
if (userinput3 == "3")
{
    Console.WriteLine("enter first number");
    string l = Console.ReadLine();
    Console.WriteLine("enter second number");
    string v = Console.ReadLine();
    decimal f = Convert.ToDecimal(l) * Convert.ToDecimal(v);
    Console.WriteLine($"{l}X{v}={f}");
}
if (userinput3 == "4")
{
    Console.WriteLine("enter first number");
    string l = Console.ReadLine();
    Console.WriteLine("enter second number");
    string v = Console.ReadLine();
    decimal f = Convert.ToDecimal(l) / Convert.ToDecimal(v);
    Console.WriteLine($"{l}/{v}={f}");
}
while (userinput3 != "5")
{
    Console.WriteLine("choose another option");
    userinput3 = Console.ReadLine();

    if (userinput3 == "1")
    {
        Console.WriteLine("enter first number");
        string l = Console.ReadLine();
        Console.WriteLine("enter second number");
        string v = Console.ReadLine();
        decimal f = Convert.ToDecimal(l) + Convert.ToDecimal(v);
        Console.WriteLine($"{l}+{v}={f}");

    }
    if (userinput3 == "2")
    {
        Console.WriteLine("enter first number");
        string l = Console.ReadLine();
        Console.WriteLine("enter second number");
        string v = Console.ReadLine();
        decimal f = Convert.ToDecimal(l) - Convert.ToDecimal(v);
        Console.WriteLine($"{l}-{v}={f}");
    }
    if (userinput3 == "3")
    {
        Console.WriteLine("enter first number");
        string l = Console.ReadLine();
        Console.WriteLine("enter second number");
        string v = Console.ReadLine();
        decimal f = Convert.ToDecimal(l) * Convert.ToDecimal(v);
        Console.WriteLine($"{l}X{v}={f}");
    }
    if (userinput3 == "4")
    {
        Console.WriteLine("enter first number");
        string l = Console.ReadLine();
        Console.WriteLine("enter second number");
        string v = Console.ReadLine();
        decimal f = Convert.ToDecimal(l) / Convert.ToDecimal(v);
        Console.WriteLine($"{l}/{v}={f}");
    }
}
if (userinput3 == "5")
{
    Console.WriteLine("byeeeee");
}

