/* Задача 37: Найдите произведение пар чисел 
в одномерном массиве. парой считаем первый и последний элемент,
второй и предпоследний и т.д. Результат в новом массиве.
[1, 2, 3, 4, 5] -> 5 8 3;
[6, 7, 3, 6] -> 36 21;
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

int[] ProductPairsNumbers(int[] arr) {
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size +=1;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++) {
        newArr[i] = arr[i] * arr[arr.Length -1 - i];
    }
    if (arr.Length % 2 != 0) {
        newArr[size - 1] = arr[arr.Length / 2]; 
    }
    return newArr;
}

int[] array = CreateArraayRndInt(5, 1, 9);
PrintArray(array);

int[] resArr = ProductPairsNumbers(array);
PrintArray(resArr);