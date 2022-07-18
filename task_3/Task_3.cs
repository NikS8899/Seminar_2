// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber > 0 & dayNumber < 8)
{
    if (dayNumber == 6 | dayNumber == 7)
    {
        System.Console.WriteLine("Ура выходной!");
    }
    else {
        System.Console.WriteLine("Будний день");
    }
}
else {
    System.Console.WriteLine("Такого дня недели нет");
}