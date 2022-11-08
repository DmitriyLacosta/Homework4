//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Программа выдаёт сумму цифр в числе");
Console.WriteLine("введите число: ");

int n = int.Parse(Console.ReadLine()!);

void sumdigits(int n)
{
n = Math.Abs(n);
int sum = 0;
while (n != 0) 
{
    sum += n % 10;
    n /= 10;
}
Console.WriteLine(sum);
}

sumdigits(n);
