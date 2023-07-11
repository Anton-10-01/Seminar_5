/* Задача 31: Задайте массив из 12 элементов
заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных чисел.

Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма
положительных чисел равна 29, сумма отрицательных чисел равна -20.
*/

int[] CreateArrayRndInt(int size, int min, int max) {
    int[] arr = new int[size];
    Random rand = new Random();
    
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        if (i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[] GetSumPostiveNegativeElem(int[] arr) {
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] < 0) sumNegative += arr[i];
        else sumPositive += arr[i];
    }
    return new int[]{sumPositive, sumNegative};
}

int GetSumPostiveElem(int[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int[] sumPostiveNegativeElem = GetSumPostiveNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов = {sumPostiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPostiveNegativeElem[1]}");

int sumPositiveElem = GetSumPostiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");
