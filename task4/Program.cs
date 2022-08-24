// Напишите программу, которая принимает на вход случайно сгенерированное число (от 1 до 1 000 000) 
// и проверяет, кратно ли оно одновременно 7 и 23.

int Number = new Random().Next(1, 1000000);
Console.WriteLine(Number);

if (Number % 7 == 0 && Number % 23 == 0)
{
    Console.WriteLine("true");
}
else
Console.WriteLine("false");
