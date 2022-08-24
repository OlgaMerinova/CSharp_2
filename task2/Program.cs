// Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) 
// или сообщает, что третьей цифры нет.

int Number = new Random().Next(1, 65536);
if (Number > 99 && Number <= 999)
{
    int digit_third = (Number / 100) % 10;
    Console.WriteLine(digit_third);
}
else
Console.WriteLine("третьего числа нет");

