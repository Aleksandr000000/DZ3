/// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int GetNumber()
{
    Console.Write("Введите пятизначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool RazrNumber (int number) /// метод разрядности числа и сравнения их
{
    int DecT = (number/10000)%10;
    int tic = (number/1000)%10;
    int Sot = (number/100)%10;
    int Dec = (number/10)%10;
    int Ed = number%10;
    if (DecT == Ed && tic == Dec)
    return true;
    else return false;
                
}
int a = GetNumber();
bool b = RazrNumber(a);
if (b == true)
    Console.WriteLine("Число  " + a + "  является палиндромом");
else
    Console.WriteLine("Число  " + a + "  не является палиндромом");

