// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write(userNumber1 + " -> ");

if (userNumber1 % 2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");