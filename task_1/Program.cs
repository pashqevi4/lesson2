int a = new Random().Next(100,1000);
Console.WriteLine(a);
int x = a / 100 * 10;
int y = a % 10;
int z = x + y;
Console.WriteLine(z);