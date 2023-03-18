Console.Write("Введите количество элементов массива: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine (a);
int[] randomArr = new int[a];
void mas (int a)
{
  for (int i = 0; i<a; i++)
{
randomArr[i] =new Random().Next(99,999);
Console.WriteLine(randomArr[i]+"");
}
}
int kol (int[] randomArr)
{
  int kol =0;
  for(int i =0;i< randomArr.Length; i++)
  {
    if( randomArr[i] % 2 == 0)
    kol = kol +1;
  } 
  return kol;
}
mas(a);
Console.WriteLine($"количество чётных чисел в массиве: {kol(randomArr)}");
