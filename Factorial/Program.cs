int factorial = 0;
Console.WriteLine("Input a number that will be your factorial: ");
try
{
    factorial = Convert.ToInt32(Console.ReadLine());
    if (factorial < 0) Console.WriteLine("Number need to be positive.");
}
catch
{
    Console.WriteLine("Wrong input. Not a number!!!");
}

