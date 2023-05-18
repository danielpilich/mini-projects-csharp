int count = 0;
try
{
    Console.WriteLine("Input a number how many factorials do you want: ");
    count = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Wrong input. Not a number!!!");
}

int[] factorial = new int[count];
Console.WriteLine("Input a number/s that will be your factorial/s: ");
for (int i = 0; i < count;)
{
    try
    {
        factorial[i] = Convert.ToInt32(Console.ReadLine());
        if (factorial[i] < 0)
        {
            Console.WriteLine("Number have to be positive or zero. Try again: ");
        }
        else
        {
            i++;
        }
    }
    catch
    {
        Console.WriteLine("Wrong input. Not a number!!!");
    }
}

for (int i = 0; i < factorial.Length; i++)
{
    Console.Write($"The value of factorial {factorial[i]} is: ");
    if (factorial[i] > 1)
    {
        for (int j = factorial[i] - 1; j > 1; j--)
        {
            factorial[i] *= j;

        }
    }
    else
    {
        factorial[i] = 1;
    }
    Console.WriteLine(factorial[i]);
}


