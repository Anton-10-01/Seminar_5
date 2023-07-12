/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] CreateArrayRndDouble(int size, int min, int max) {
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++) {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr, int round) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) {
        double num = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{num}, ");
        else Console.Write($"{num}");
    }
    Console.Write("] -> ");
}


double MaxElement(double[] arr, int round = 1) {
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++) {
        if (max < arr[i]) {
            max = arr[i];
        }
    }
    return Math.Round(max, round);
}

double MinElement(double[] arr, int round = 1) {
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++) {
        if (min > arr[i]) {
            min = arr[i];
        }
    }
    return Math.Round(min, round);
}

double DifferenceElement(double max, double min) {
    double diff = max - min;
    return diff;
}

double[] array = CreateArrayRndDouble(4, 1, 10);
PrintArrayDouble(array, 1);

double result = DifferenceElement(MaxElement(array), MinElement(array));
Console.WriteLine(Math.Round(result, 1));