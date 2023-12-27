// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// int M=new Random().Next(1, 10);
// Console.Write(M + " ");

// int N=new Random().Next(10,21);
// Console.Write(N);

// Console.WriteLine();

// void Print(int start, int end)
// {
// Console.WriteLine(start);
// if (start==end)
// {
//     return;
// }
// Print(start+1, end);
// }

// Console.WriteLine();

// Print(M, N);



// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// int M=new Random().Next(0,4);
// Console.Write(M + " ");

// int N=new Random().Next(0,7);
// Console.Write(N);

// Console.WriteLine();

// int LeviAckerman(int m, int n)
// {
// if (m==0)
// {
// return n+1;
// }
// if (m>0 && n==0)
// {
// return LeviAckerman(m-1, 1);
// }
// else
// {
// return LeviAckerman(m-1, LeviAckerman(m, n-1));
// }
// }

// int A=LeviAckerman(M, N);
// Console.WriteLine(A);



// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

// int[]mihanzo=new int[10];
// int i=1;

// void Create()
// {
//     for (int i = 0; i < mihanzo.Length; i++)
//     {
//         mihanzo[i]=new Random().Next(1,11);
//         Console.Write(mihanzo[i] + " ");
//     }
// }
// Create();

// Console.WriteLine();

// void Inverse(int[]array, int index)
// {
//     if(index>array.Length)
//     {
//         return;
//     }
//     Console.Write(array[array.Length - index]+ " ");
//     Inverse(array, index+1);
// }

// Inverse(mihanzo, i);