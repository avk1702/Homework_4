internal class Program
{
  private static void Main(string[] args)
  {
    //Задача 29: Напишите метод, который задаёт массив из N элементов 
    // и выводит их на экран.
    // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    // 6, 1, 33 -> [6, 1, 33]
    int size, index;
    Console.Write("Введите количество элементов в массиве:  ");
    size = Convert.ToInt32(Console.ReadLine());
    index = 0;

    while (index < size)
    {
      int[] col = new int[size];
      Random rand = new Random();
      col[index] = rand.Next(10);
      Console.Write(col[index].ToString() + " ");
      index = index + 1;
    }
  }
}





