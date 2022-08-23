// Программа, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

int number;
Console.WriteLine("Введите цифру, обозначающую день недели: ");
number = Convert.ToInt32(Console.ReadLine());

switch(number)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Нет, это не выходной");
        break;
    case 6:
    case 7:
        Console.WriteLine("Да, это выходной");
        break;
    default:
        Console.WriteLine("Нет такого дня недели");
        break;
}