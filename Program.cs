// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49


Console.WriteLine("введите целое число 1");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите целое число 2");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int square = numberOne * numberOne;
if (numberTwo == square)
{
    Console.WriteLine( $" {numberOne}, {numberTwo} -> Да ");
    }
else
{
    Console.WriteLine($"{numberOne}, {numberTwo} -> No");
}