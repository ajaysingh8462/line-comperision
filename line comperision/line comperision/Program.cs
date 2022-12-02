// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
{
    Console.WriteLine("Please enter x1 and y1 co-ordinates: ");
    var x1 = Convert.ToDouble(Console.ReadLine());
    var y1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("please enter x2 and y2 co-ordinetes: ");
    var x2 = Convert.ToDouble(Console.ReadLine());
    var y2 = Convert.ToDouble(Console.ReadLine());

    Double distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
        Console.WriteLine( "the length of to points is  "+(Math.Round(distance)));
    {
        if ((x1 / x2 == y1 / y2))

          Console.WriteLine("The given straight"
        + " lines are equal");

        else
            Console.WriteLine("The given straight"
            + " lines are not equal");

    }



















}
