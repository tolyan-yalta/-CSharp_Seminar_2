// Программа, которая выводит третью цифру случайно сгенерированного числа (от 1 до любого числа)
// или сообщает, что третьей цифры нет.
Console.Clear();

Console.WriteLine("Введите верхний предел сгенерированного числа: ");
int number_limit = Convert.ToInt32(Console.ReadLine());

int var = 100;

int number = new Random().Next(1, number_limit);

if(number < var)
{
   Console.WriteLine("Третьей цифры нет");
}
else
{
    while(var < number_limit)
    {
        var = var*10;
        if(number < var)
        {
            int temp = var / 100;
            int temp1 = number % temp;
            int digit = var / 1000;
            int digit1 = temp1 / digit;
            Console.WriteLine("Сгенерировано число " + number + ", третья цифра " + digit1);
            break;
        }
        
    }
}
