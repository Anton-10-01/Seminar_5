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
    Console.Write("] => ");

    double result = DifferenceElement(MaxElement(arr), MinElement(arr));
    Console.Write($"{MaxElement(arr)} - {MinElement(arr)} = {result}");
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

double DifferenceElement(double max, double min, int round = 1) {
    double diff = max - min;
    return Math.Round(diff, round);
}

double[] array = CreateArrayRndDouble(5, 1, 10);

PrintArrayDouble(array, 1);