/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("ВЫ ВВЕЛИ НЕ ЧИСЛО");
        }
    }

    return result;
}


int a = GetNumber("Введите число 1");
int b = GetNumber("Введите число 2");

Console.WriteLine(Math.Pow((a),b));