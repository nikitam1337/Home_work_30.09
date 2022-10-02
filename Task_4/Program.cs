// Задача 4: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

int N = userNumber1;
int count = 1;

Console.Write(N + " -> ");

while (count <= N)
{
    if (count % 2 == 0) Console.Write(count + ", ");
    count++;
}