// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int max_num = 0;
// int [] array = new int [size];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(10,100);
// }
// printArray(array);
// void printArray(int[] array)
// {
//     Console.Write($"[{array[0]}");
//     for (int i = 1; i < array.Length; i++)
//         Console.Write($", {array[i]}");
//     Console.WriteLine($"]");
// }
// int min_num = array[0];
// int result = 0;
// void resultat (int max_num, int min_num, int result)
// {
//  for (int i = 0; i < array.Length; i++)
//     {
//         if (array [i] > max_num)
//         {
//             max_num = array[i];
//         }
//         else if (array[i] < min_num)
//         {
//             min_num = array[i];
//         }
//      result = max_num - min_num;
//     }
// Console.WriteLine("Минимальное значение " + min_num);
// Console.WriteLine("Максимальное значение " + max_num);
// Console.WriteLine("Результат " + result);
// }
// resultat(max_num, min_num,result);