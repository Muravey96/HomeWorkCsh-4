/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();
int num1 = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода");
int num2 = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода");
int numExponent = Convert.ToInt32(GetExponent (num1, num2));
Console.WriteLine($"{num1}^{num2} -> {numExponent}");


/////////

int GetNumberFromUser (string message, string errorMessage)
{
   while(true)
   {
    Console.Write(message);
    bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
    if(isCorrect)  return userNumber;
    Console.WriteLine(errorMessage);
   }
}

///////

double GetExponent( double number1, Double number2 )
{
    int expo = 0;
    while (number1>0 && number2>0)
    {
        expo = Convert.ToInt32(Math.Pow(number1, number2));
        return expo;
    }
    return expo;
}

// !! Почему-то если не вставить return expo; в 33 строчку цикл зацикливался, а если не вставить в 35 строчку - выдает ошибку
// пришлось продублировать 