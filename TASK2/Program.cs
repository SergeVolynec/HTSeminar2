Console.Write("Введите семизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * (-1);

if (number < 1000000)
{
    Console.WriteLine("В введенном числе менее семи цифр");
    return;
}

if (number > 9999999)
{
    Console.WriteLine("В введенном числе более семи цифр");
    return;
}

int leftThirdDigit = (number / 10000) % 10;
int rightThirdDigit = (number / 100) % 10;
Console.WriteLine($" Третья цифра слева в числе {number}: {leftThirdDigit} \n Третья цифра справа в числе {number}: {rightThirdDigit}");
