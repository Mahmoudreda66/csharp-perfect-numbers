class App
{
    public static void Main()
    {
        while (true)
        {
            // read parameters
            Console.WriteLine("Enter Start Number");
            double start = validateInteger(Console.ReadLine());
            Console.WriteLine("Enter End Number");
            double end = validateInteger(Console.ReadLine());

            if (start == -1 || end == -1)
            { // check on validation
                Console.WriteLine("Invalid Parameters");
            }

            double counter;
            for (double i = start; i < end; i++)
            {
                counter = 1;

                double sum = 0;

                while (counter < i)
                {
                    if (i % counter == 0)
                    {
                        sum = sum + counter;
                    }

                    counter++;
                }

                if (sum == i)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }
    }

    // validate double function => returns -1 on failure
    public static double validateInteger(string number)
    {
        if (double.TryParse(number, out double doubleVal) && doubleVal <= double.MaxValue)
        {
            return doubleVal;
        }

        return -1;
    }

    // determines if given number is prime
    public static bool numberIsPrime(double number)
    {
        if (number == 1)
        {
            return false;
        }

        for (double i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}