// Программа, которая принимает на вход случайно сгенерированное число (от 1 до 1 000 000)
// и проверяет, кратно ли оно одновременно 7 и 23.

int number = new Random().Next(1, 1000001);

int remainder1 = number % 7;
bool temp1 = remainder1 == 0;

int remainder2 = number % 23;
bool temp2 = remainder2 == 0;

if(temp1 && temp2)
{
    Console.WriteLine("Прогамма сгенерировала число: " + number + " это число кратно одновременно и 7 и 23");
}
else
{
    Console.WriteLine("Прогамма сгенерировала число: " + number + " это число не кратно одновременно и 7 и 23");
}
