int count = 0;

Console.WriteLine("Input how many number you what to check: ");
try
{
    count = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Wrong input. Not a number!!!");
}

int[] numbers = new int[count];
bool[] results = new bool[count];

Console.Write("Input a number/numbers to check if it is a prime number: ");

for (int i = 0; i < count; i++)
{
    try
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Wrong input. Not a number!!!");
    }


    for (int j = 2; j <= numbers[i] / 2; j++)
    {
        if (numbers[i] % j == 0)
        {
            results[i] = true;
            break;
        }
    }
}
Console.Clear();


for (int i = 0; i < count; i++)
{
    if (results[i]) Console.WriteLine($"{numbers[i]} is not a prime number :(");
    else Console.WriteLine($"{numbers[i]} is a prime number :)");
}