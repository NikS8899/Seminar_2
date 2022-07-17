// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет!");
}

while (number > 999)
{
   number = number / 10;
}
if (number >= 100 && number <= 999)
{int thirdDigit = number % 10;
Console.WriteLine("Третья цифра числа: " + thirdDigit);}
