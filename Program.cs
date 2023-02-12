// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// string GetPow(int a, int b)
// {
//     int result = a;
//     for(int i = 0; i < (b - 1); i++)
//     {
//         result = result * a;
//     }

//     return Convert.ToString(result);
// }

// Console.Write("Введите число (A): ");
// int numA = Convert.ToInt32(Console.ReadLine());

// Console.Write("В какую степерь возвести число (B)? ");
// int numB = Convert.ToInt32(Console.ReadLine());

// Console.Write(GetPow(numA, numB));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumofTNumbers(int num)
// {
//     int sum = 0;
//     for(int i = 0; num > 0; i++)
//     {
//         sum = sum + num%10;
//         num = num / 10;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число для рассчет суммы цифр ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumofTNumbers(number));

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// Console.WriteLine("Сколько будет элементов в массиве (m)? ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[] LineToArray(int m)
// {
//     int[] arr = new int[m];
//     for(int i = 0; i < m; i++)
//     {
//         arr[i] = Convert.ToInt32(Console.ReadLine());   
//     }
//     return arr;
// }
// Console.WriteLine(string.Join(",", LineToArray(m)));