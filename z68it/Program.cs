// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите два положительных числа: M и N.");
int M = InputInt("Введите M:");
int N = InputInt("Введите N:");
int InputInt(string output)
  {
    Console.Write(output);
    return int.Parse(Console.ReadLine());
  }
if (M < 1)
    {
      Console.WriteLine("введено не положительное число");
    }
if (N < 1)
    {
      Console.WriteLine("введено не положительное число");
    }
else
  {
  Console.WriteLine($"A({M}, {N}) = {Akkerman(M, N)}");
 
  int Akkerman(int M, int N)
    {
      if (M == 0)
        return N + 1;
      if (M > 0 && N == 0)
        return Akkerman(M - 1, 1);
      else
        return Akkerman(M - 1, Akkerman(M, N - 1));
    }
  }