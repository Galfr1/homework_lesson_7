double input()
{
    try
    {
        Console.WriteLine("Please enter a number, then press enter:");
        return double.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("You didn't enter a valid number using the default 6.");
        return 6;
    }
}

double d1 = input();
double d2 = input();
double d3 = input();

if (((d1+d2) > d3) && ((d3 + d2) > d1) && ((d1 + d3) > d2))
{
    if ((d1 == d2) && (d2==d3))
    {
        Console.WriteLine("The following numbers can create a triangle with all edges equal, the scope is: " + (d1+d2+d3));
    }
    else if ((d1 == d2) || (d2 == d3))
    {
        Console.WriteLine("The following numbers can create a triangle with 2 edges equal, the scope is: " + (d1+d2+d3));
    }
    else
    {
        Console.WriteLine("The following numbers can create a triangle, the scope is: " + (d1+d2+d3));
    }
}
else
{
    Console.WriteLine("The following numbers can't create a triangle.");
}