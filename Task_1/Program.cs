//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void Main()
{
    int numberM = ReadIntM("введите число M: ");
    int numberN = ReadIntN("введите число N: ");
    PrintNumbers(numberM, numberN);

}

int ReadIntM(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int ReadIntN(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintNumbers(int M, int N)
{
    if (N < M) return;
    PrintNumbers(M, N - 1);
    System.Console.Write(N + " ");
}

Main(); 
