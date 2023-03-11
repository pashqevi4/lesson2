Console.WriteLine("Enter Your Number");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0)
{
    if (a % 23 == 0)
    {
        Console.WriteLine("Success");
    }
    else
    {
        Console.WriteLine("Error");
    }
}else
{
    Console.WriteLine("Error");
}