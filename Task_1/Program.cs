// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

void FindPoint(int a1, int c1, int a2, int c2)
{
    if (Math.Abs(a1) == Math.Abs(a2))
    {
        if (c1 == c2) Console.WriteLine("Прямые совпадают");
        else Console.WriteLine("Прямые параллельны ");
    }
    else Console.WriteLine($"Координаты:{((c2 - c1) / (a1 - a2))},{a1 * (c2 - c1) / (a1 - a2) + c1}");
}
Console.WriteLine("Введите k1,b1,k2,b2: ");
int k1 = int.Parse(Console.ReadLine()?? "0");
int b1 = int.Parse(Console.ReadLine()?? "0");
int k2 = int.Parse(Console.ReadLine()?? "0");
int b2 = int.Parse(Console.ReadLine()?? "0");
FindPoint(k1, b1, k2, b2);