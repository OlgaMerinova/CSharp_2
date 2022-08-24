// Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int Number =  new Random().Next(100, 999);
Console.WriteLine(Number);
int digit_second = (Number / 10) % 10;
Console.WriteLine(digit_second);

