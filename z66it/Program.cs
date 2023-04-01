// See https://aka.ms/new-console-template for more information
int M = InputInt("Введите M:");
int N = InputInt("Введите N:");
Console.WriteLine($"Сумма элементов от {M} до {N} = {CountNaturalSum(M, N)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int M, int N)
{
    if (M == N)
        return N;
    return N + CountNaturalSum(M, N - 1);
}