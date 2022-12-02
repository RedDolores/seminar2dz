// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 7 || number < 1)
{
    Console.WriteLine("Такого дня недели не существует. Повторите ввод: ");
    number = Convert.ToInt32(Console.ReadLine());
}

if(number == 6 || number == 7) Console.WriteLine("yes");
else Console.WriteLine("no");
