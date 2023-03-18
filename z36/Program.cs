Console.Write("Введите количество элементов массива: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine (a);
int[] randomArr = new int[a];
void mas (int a)
{
  for (int i = 0; i<a; i++)
{
randomArr[i] =new Random().Next(1,9);
Console.WriteLine(randomArr[i]+"");
}
}
int kol (int[] randomArr)
{
  int sum =0;
  int i = 0;
  while (i< randomArr.Length)
  {
  sum = sum+randomArr[i];
    i = i +2;
  } 
  return sum;
}
mas(a);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {kol(randomArr)}");
