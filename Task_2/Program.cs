// Программа, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536)
// или сообщает, что третьей цифры нет.

int number = new Random().Next(1, 65537);

if(number < 100)
{
   Console.WriteLine("Третьей цифры нет");
}
else
{
    if(number < 1000)
    {
        int digit = number % 10;
        Console.WriteLine("Сгенерировано число " + number + ", третья цифра " + digit);
    }
    else
    {
        if(number < 10000)
        {
            int temp = number % 100;
            int digit = temp / 10;
            Console.WriteLine("Сгенерировано число " + number + ", третья цифра " + digit);
        }
        else
        {
            int temp = number % 1000;
            int digit = temp / 100;
            Console.WriteLine("Сгенерировано число " + number + ", третья цифра " + digit);
        }
    }
}
