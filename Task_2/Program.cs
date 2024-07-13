
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
void Main()
{
    int numberM = ReadIntM("введите число m: ");
    int numberN = ReadIntN("введите число n: ");
    System.Console.WriteLine(A(numberM, numberN));
}

int A(int m, int n)
{
    if(m==0)
    return n+1;
    else if(m>0 && n==0)
    return A(m-1,1);
    else 
    return A(m - 1, A(m, n - 1));

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

Main();
