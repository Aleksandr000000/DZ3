// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int  GetNumber() /// метод ввода числа 
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}
void GetPrintPow (int number) // метод возведения в  степень 

{
    int Count = 0;
    Console.WriteLine("таблица кубов от 1 до " + number);
    while (Count <= number)
    {
        Console.Write("->" + Math.Pow(Count,3)+" ");
        Count ++;
    }
}
GetPrintPow(GetNumber());
