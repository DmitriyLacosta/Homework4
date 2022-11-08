// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

Console.WriteLine("Программа выдаёт массив из 8 целых чисел с клавиатуры");
Console.WriteLine("введите размер массива: ");
int N = int.Parse(Console.ReadLine()!);
int[] myArray = new int[N];

 //Ввод с клавиатуры.
Console.WriteLine("введите числа в массиве через Enter: ");
for (int i=0; i<N; i++)
{
    myArray[i] = Convert.ToInt32(Console.ReadLine()!);
}

//Вывод на экран.
Console.WriteLine("Введеный массив:");
for (int i = 0; i < N; i++)
{
    Console.Write("{0} ", myArray[i]);
}
