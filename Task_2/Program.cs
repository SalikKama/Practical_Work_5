// Показать числа Фибоначчи
int n = 100;
int a1 = 0;
int a2 = 1;
int temp = 0;
Console.Write($"{a1} {a2} ");
while (a1 + a2 <= n)
{
    Console.Write((a1+a2) + " ");
    temp = a2;
    a2 = a1 + a2;
    a1 = temp;
}