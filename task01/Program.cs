// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
       
Console.Write("Введите чиcло В: ");
int numberB = int.Parse(Console.ReadLine());
       
int result = 1;
for (int i = 0; i < numberB; i++)
{
    result *= numberA;
}
Console.WriteLine("{0} ^ {1} = {2}", numberA, numberB, result);
Console.ReadKey();
return 0;


