// Задача 25: Напишите метод, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//нельзя использовать Math.Pow 3, 5 -> 243 (3⁵) 2, 4 -> 16

int ApowB(int a, int b)
{
  int pow = a;
  for (int i = 1; i < b; i++)
  {
    pow = pow * a;
  }
  return pow;
}

Console.Write("Введите число A:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" A в степени B  = " + (ApowB(a, b)));