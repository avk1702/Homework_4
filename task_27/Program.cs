// Задача 27: Напишите метод, который принимает на вход число и 
// выдаёт сумму цифр в числе. 452 -> 11 82 -> 10 9012 -> 12

internal class Program
{
  private static void Main(string[] args)
  {
    Console.Write("Введите число:  ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (number > 0)
    {
      sum += number % 10;
      number = number / 10;
    }
    Console.WriteLine($" Сумма всех цифр в числе " + sum);
  }
}