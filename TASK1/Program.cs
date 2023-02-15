Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * (-1);
if (number < 100 || number > 999)
{
    Console.WriteLine("Число должно быть трехзначным!");
    return;
}

int secondDigit = (number / 10) % 10;
Console.WriteLine($"Вторая цифра в числе {number}: {secondDigit}");