// Программа, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

int number;
Console.WriteLine("Введите цифру, обозначающую день недели: ");
number = Convert.ToInt32(Console.ReadLine());

switch(number)
{
    case 1:
        Console.WriteLine("Нет, это не выходной");
        break;
    case 2:
        Console.WriteLine("Нет, это не выходной");
        break;
    case 3:
        Console.WriteLine("Нет, это не выходной");
        break;
    case 4:
        Console.WriteLine("Нет, это не выходной");
        break;
    case 5:
        Console.WriteLine("Нет, это не выходной");
        break;
    case 6:
        Console.WriteLine("Да, это выходной");
        break;
    case 7:
        Console.WriteLine("Да, это выходной");
        break;
}