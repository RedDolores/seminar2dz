// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number > 999 || number < 100 )
{
    Console.WriteLine("Число не трехзначное. Повторите ввод: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int res = number / 10;

Console.WriteLine($"Результат {res % 10}");

