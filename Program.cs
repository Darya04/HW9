// Все задачи решаются с помощью рекурсии
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNumberToN(int N)
// {
// System.Console.Write($"{N} ");
// {
// if(N == 1)
// {
// return;
// }
// PrintNumberToN(N - 1);
// }
// }
// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintNumberToN(number);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int Numbers(int M, int N)

// {
// if (M-1 == N)
// {
//     return 0;
// }
// return N + Numbers(M,N-1);
// }

// System.Console.Write("Введите число M: ");
// int A = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите число N: ");
// int B = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Numbers(A, B));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Numbers(int M, int N)

{
if (M == 0)
{
    return N+1;
}
else if (M>0 && N==0)
{
    return Numbers(M-1,1);
}
else if (M>0 && N>0)
{
    return Numbers(M-1,Numbers(M,N-1));
}
return N + Numbers(M,N-1);
}

System.Console.Write("Введите число M: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Numbers(A, B));