// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
{
    Console.WriteLine("Please enter x1 and y1 co-ordinates: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("please enter x2 and y2 co-ordinetes: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    double y2 = Convert.ToDouble(Console.ReadLine());

    double distance = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        Console.WriteLine( "the length of to points is  "+(distance));
    {
        if ((x1 / x2 == y1 / y2))

          Console.WriteLine("The given straight"
        + " lines are equal");

        else
            Console.WriteLine("The given straight"
            + " lines are not equal");

       
        
    }



















}
