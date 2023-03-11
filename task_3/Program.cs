int a = new Random().Next(1,1000000);
Console.WriteLine(a);
int c = 38;
int b = a % c;
Console.WriteLine($"Остаток от числа {a} при делении на {c} равен {b}");