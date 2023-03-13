Console.Clear();
Console.Write("Введите 3-значное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10;
int n2 = n1 % 10;
Console.WriteLine(n2);