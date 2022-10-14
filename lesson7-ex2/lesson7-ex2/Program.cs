string boom()
{
    try
    {
        Console.WriteLine("Please enter a positive number less than 100, then press enter:");
        int input = int.Parse(Console.ReadLine());

        if(input <= 100)
        {
            if (((input % 7) == 0) || (input / 10) == 7 || (input % 10) == 7)
            {
                return "boom!";
            }
            else
            {
                return "Not boom...";
            }
        }
        else
        {
            return "You didn't enter a valid number.";
        }
    }
    catch
    {
        return "You didn't enter a valid number.";
    }
}

Console.WriteLine(boom());