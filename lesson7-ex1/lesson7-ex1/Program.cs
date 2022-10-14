double num()
{
    Console.WriteLine("Please enter a char, then press enter:");

    try
    {
        return char.GetNumericValue(char.Parse(Console.ReadLine()));
    }
    catch
    {
        Console.WriteLine("You didn't enter a digit, using the default 1.");
        return 1;
    }
}

double num1 = num();
double num2 = num();
double num3 = num();

Console.WriteLine("From the following digit you can create 3 numbers: "+((num1*100)+(num2*10)+num3)+", " + ((num3 * 100) + (num2 * 10) + num1) + ", " + ((num2 * 100) + (num1 * 10) + num3));
Console.WriteLine("The sum of the 3 digits is: " + (num1 + num2 + num3));