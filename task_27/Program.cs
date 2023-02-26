// Задача 27: Напишите метод, который принимает на вход число и 
// выдаёт сумму цифр в числе. 452 -> 11 82 -> 10 9012 -> 12

int SummAll (int number)
{
  int sum = 0;
    while (number > 0)
    {
    int i = number % 10;
    number = number / 10;
    sum = sum + i;
    }
    return sum;
} 
    
Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Сумма всех цифр в числе " + (SummAll(number)));