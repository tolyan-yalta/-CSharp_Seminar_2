// Программа, которая выводит третью цифру случайно сгенерированного числа (от 1 до любого числа)
// или сообщает, что третьей цифры нет.
Console.Clear();

Console.WriteLine("Введите верхний предел сгенерированного числа: ");
int number_limit = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next(1, number_limit);

int category_numbers = 100;

if(number < category_numbers)
{
   Console.WriteLine("Третьей цифры нет");
}
else
{
    while(category_numbers < number_limit)
    {
        category_numbers = category_numbers * 10;
        if(number < category_numbers)
        {
            int temp = number % (category_numbers / 100);
            int digit = temp / (category_numbers / 1000);
            Console.WriteLine("Сгенерировано число " + number + ", третья цифра " + digit);
            break;
        }
        
    }
}
