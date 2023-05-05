int number = 0;

Console.Write("Input a number to check if it is a prime number: ");
try
{
    number = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Wrong input. Not a number!!!");
}

bool result = true;
for (int i = 2; i < number / 2; i++)
{
    if (number % i == 0)
    {
        result = false;
        break;
    }
}

if (result)
    Console.WriteLine("This is a prime number :)");
else
    Console.WriteLine("This is not a prime number :(");