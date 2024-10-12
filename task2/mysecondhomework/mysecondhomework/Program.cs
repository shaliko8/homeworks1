using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        var a = 32;
        var b = 22;

        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);
        Console.WriteLine("-----------------------------------");
        float c = 1.0f / 7.0f;
        double d = 1.0 / 7.0;
        decimal e = 1.0m / 7.0m;


        Console.WriteLine(e * 7);
        Console.WriteLine(d * 7);
        Console.WriteLine(e * 7);
        Console.WriteLine("-----------------------------------");
        int f = 5;
        int g = Convert.ToInt32(d);
        Console.WriteLine(g);
        double h = Convert.ToDouble(f);
        Console.WriteLine(h);
        float i = (float)e;
        Console.WriteLine(i);
        decimal j = Convert.ToDecimal(c);
        Console.WriteLine(j);
        Console.WriteLine("-----------------------------------");

        Console.WriteLine("write letters, symbols or numbers ");
        string gh = Console.ReadLine();
        Console.WriteLine("x=" + (gh));
        Console.WriteLine("write letters, symbols or numbers once more ");
        string hg = Console.ReadLine();
        Console.WriteLine("y=" + (hg));
        Console.WriteLine("now say mirror ");
        string ragac = Console.ReadLine();

        if (ragac == "mirror")
        {
            Console.WriteLine("x=" + (hg));
            Console.WriteLine("y=" + (gh));
        }
        else
        {
            Console.WriteLine("just copy if you can't write");
            while (Console.ReadLine() != "mirror")
            {
                Console.WriteLine("what a dumbass");
            }

        }




        Console.WriteLine("-----------------------------------");
        double height;
        double weight;
        Console.WriteLine("Enter your height(meters): ");
        height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your weight(kg): ");
        weight = Convert.ToDouble(Console.ReadLine());
        double BMI = (weight) / (height * height);

        if ((BMI) < 25)
        {
            Console.WriteLine("good job ");

        }
        else
        {
            Console.WriteLine("you are obese you fat nugget");

        }

    }
}