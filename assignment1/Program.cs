Console.Write("Enter the first number:\n");
string firstNumber = Console.ReadLine();
float firstNumFloat = float.Parse(firstNumber);

Console.Write("Enter the second number:\n");
string secondNumber = Console.ReadLine();
float secondNumFloat = float.Parse(secondNumber);

Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~\n");
Console.Write(" 1.Addation.\n 2.Subtraction.\n 3.Multiplication.\n 4.Division.\n");
Console.Write("Enter the operation you want to do:\n");
string operation = Console.ReadLine();
int operationInt = int.Parse(operation);


if (operationInt == 1)
{
    Console.Write($"The result is:{firstNumFloat + secondNumFloat}");
}
else if ( operationInt == 2)
{
    Console.Write($"The result is: {firstNumFloat - secondNumFloat}");
}
else if ( operationInt == 3)
{
    Console.Write($"The result is: {firstNumFloat * secondNumFloat}");
}
else if ( operationInt == 4 && secondNumFloat != 0)
{
    Console.Write($"The result is: {firstNumFloat / secondNumFloat}");
}
else
{
    Console.Write("Error! cannot complete the process.");
}