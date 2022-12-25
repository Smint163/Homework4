/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/

int GetRandomNumber()
{
    return new Random().Next(0, 100000000);
}

void ShowRandomNumber(int number)
{
    Console.WriteLine($"Массив из 8ми элементов {number}");
    string str = number.ToString();
    Console.WriteLine($"{str[0]}, {str[1]}, {str[2]}, {str[3]}, {str[4]}, {str[5]}, {str[6]}, {str[7]}");
}

ShowRandomNumber(GetRandomNumber());
