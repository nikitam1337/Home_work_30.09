// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);
int Max = 0;

if (userNumber1 > userNumber2) 
{
    Max = userNumber1;
}
else 
{
    Max = userNumber2;
}

Console.WriteLine("a = " + userNumber1 + ";" + " b = " + userNumber2 + " -> max = " + Max);