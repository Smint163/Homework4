/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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

int number = GetNumber("Введите число");

string array = number.ToString();

int summ = 0;

for(int i = 0; i < array.Length; i++)
    {
        int num = (int) char.GetNumericValue((array[i]));
        summ = summ + num;
    }

Console.WriteLine(summ);