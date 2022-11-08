// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Программа принимает два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine()!);
int count = 0;
int result = 1;
void degree(int A,int B)
{
   
    while(count<B)
    {
        result = result*A;
        count++;
    }
    
    Console.WriteLine(A + "^" + B + " = " +result);

}
degree(A,B);
//Console.WriteLine(A + "^" + B + "= " + Math.Pow(A, B));