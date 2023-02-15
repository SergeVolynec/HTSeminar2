Console.Write("Введите номер дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Неверное значение. Число должно быть от 1 до 7!");
    return;
}

if (number >= 1 && number <= 5)
{
    Console.WriteLine($"{number} - это рабочий день.");
}
else
{
    Console.WriteLine($"{number} - это выходной день.");
}

