﻿Console.WriteLine("Enter the operation (+ or - or * or /):");
char userOperator = char.Parse(Console.ReadLine());

Console.WriteLine("Enter a");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Subtracion(firstNum, secondNum);
        break;
    case '*':
        Multiply(firstNum, secondNum);
        break;
    case '/':
        Divide(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}


static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtracion(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}

static void Multiply(int a , int b)
{
    Console.WriteLine($"{a} * {b} = {a * b}");
}

static void Divide(int a , int b)
{
    Console.WriteLine($"{a} / {b} = {a / b}");
}
