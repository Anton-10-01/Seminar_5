/* Задача 35: Задайте одномерный массив из 123
случайных чисел. Найдите кол-во элементов массива, значения которых лежат
в отрезке [10, 99].
Пример для массива из 5, а не 123 элементов
[5, 18, 123, 6, 2] -> 1;
[1, 2, 3, 6, 2] -> 0;
*/

int[] CreateArraayRndInt(int size, int min, int max) {
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++) {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountTwoDigitNumbers (int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] >= 10 && arr[i] <= 99) {
            count++;
        }
    }
    return count;
}

int[] array = CreateArraayRndInt(123, -100, 100);

PrintArray(array);

int result = CountTwoDigitNumbers(array);
Console.WriteLine(result);