// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadInt(string text)
{
    System.Console.Write(text);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int Sum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int i = ReadInt("Enter your number: ");
System.Console.WriteLine($"Сумма цифр в числе {i} равняется {Sum(i)}");
