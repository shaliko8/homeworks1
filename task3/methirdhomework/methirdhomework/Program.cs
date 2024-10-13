// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;




string[] vowels = new string[] { "a", "e", "i", "o", "u" };
Console.WriteLine("type smth");
String UI = Console.ReadLine();
int vc = 0;
for (int i = 0; i < UI.Length; i++)
{
    if (vowels.Contains(UI[i].ToString()))
    {
        vc++;
    }
}

Console.WriteLine("The text you entered contains" + " " + vc + " " + "vowels");
Console.WriteLine("-----------------------------------------");

Console.WriteLine("Enter any number");
int UI1 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < 11; i++)
{
    int smth = UI1 * i;
    Console.WriteLine($" {UI1} *{i} = {smth}");

}

Console.WriteLine("-----------------------------------------");
string[,] smth1 = new string[3, 3];
string[,] smth2 = new string[3, 3];
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Console.WriteLine($"enter numbers for ({x},{y}) point of your first 3X3 matrix");
        smth1[x, y] = Console.ReadLine();

    }
}

Console.WriteLine("here is your matrix ");
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Console.Write(smth1[x, y] + "\t");
    }
    Console.WriteLine();

}
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Console.WriteLine($"enter numbers for ({x},{y}) point of your second 3X3 matrix");
        smth2[x, y] = Console.ReadLine();

    }
}

Console.WriteLine("here is your matrix ");
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Console.Write(smth2[x, y] + "\t");
    }
    Console.WriteLine();

}
Console.WriteLine("this is the sum ");
Console.WriteLine();
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        int k = Convert.ToInt32(smth1[x, y]) + Convert.ToInt32(smth2[x, y]);

        Console.Write(k + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("-----------------------------------------");

Console.Write($"Calculator Menu: \n 1) Addition \n 2) Subtraction \n  3) Multiplication \n 4) Division \n  5) Exit");
Console.WriteLine("choose an option");
string h = Console.ReadLine();


if (h == "1")
{
    Console.WriteLine("enter first number");
    string l = Console.ReadLine();
    Console.WriteLine("enter second number");
    string v = Console.ReadLine();
    int f = Convert.ToInt32(l) + Convert.ToInt32(v);
    Console.WriteLine($"{l}+{v}={f}");

}
if (h == "2")
{
    Console.WriteLine("enter first number");
    string l = Console.ReadLine();
    Console.WriteLine("enter second number");
    string v = Console.ReadLine();
    int f = Convert.ToInt32(l) - Convert.ToInt32(v);
    Console.WriteLine($"{l}-{v}={f}");
}
if (h == "3")
{
    Console.WriteLine("enter first number");
    string l = Console.ReadLine();
    Console.WriteLine("enter second number");
    string v = Console.ReadLine();
    int f = Convert.ToInt32(l) * Convert.ToInt32(v);
    Console.WriteLine($"{l}X{v}={f}");
}
if (h == "4")
{
    Console.WriteLine("enter first number");
    string l = Console.ReadLine();
    Console.WriteLine("enter second number");
    string v = Console.ReadLine();
    double f = Convert.ToDouble(l) / Convert.ToDouble(v);
    Console.WriteLine($"{l}/{v}={f}");
}
while (h != "5")
{
    Console.WriteLine("choose another option");
    h = Console.ReadLine();

    if (h == "1")
    {
        Console.WriteLine("enter first number");
        string l = Console.ReadLine();
        Console.WriteLine("enter second number");
        string v = Console.ReadLine();
        int f = Convert.ToInt32(l) + Convert.ToInt32(v);
        Console.WriteLine($"{l}+{v}={f}");

    }
    if (h == "2")
    {
        Console.WriteLine("enter first number");
        string l = Console.ReadLine();
        Console.WriteLine("enter second number");
        string v = Console.ReadLine();
        int f = Convert.ToInt32(l) - Convert.ToInt32(v);
        Console.WriteLine($"{l}-{v}={f}");
    }
    if (h == "3")
    {
        Console.WriteLine("enter first number");
        string l = Console.ReadLine();
        Console.WriteLine("enter second number");
        string v = Console.ReadLine();
        int f = Convert.ToInt32(l) * Convert.ToInt32(v);
        Console.WriteLine($"{l}X{v}={f}");
    }
    if (h == "4")
    {
        Console.WriteLine("enter first number");
        string l = Console.ReadLine();
        Console.WriteLine("enter second number");
        string v = Console.ReadLine();
        double f = Convert.ToDouble(l) / Convert.ToDouble(v);
        Console.WriteLine($"{l}/{v}={f}");
    }
}
if (h == "5")
{
    Console.WriteLine("byeeeee");
}


