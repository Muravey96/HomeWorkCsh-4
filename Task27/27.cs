/*  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

 Console.Clear();
int userNum = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int sum = GetSumForNumber(userNum);
Console.WriteLine($"{userNum} -> {sum}");




//////////
int GetNumberFromUser(string message, string errorMessage)

{
    while(true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNum);
        if (isCorrect)  return userNum;
        Console.WriteLine(errorMessage);
    }
}

/////////
int GetSumForNumber (int number)
{
    int counter = Convert.ToString(number).Length;
    int middleres = 0;
    int result = 0;

    for (int i=0; i<counter; i++ )
    {
      middleres = number - number % 10;
      result = result + (number - middleres);
      number = number / 10;
    }
   return result;
}

