// Задание 1. Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random random = new Random();

    for(int i = 0; i < size; i++){

        array[i] = random.Next(leftRange, rightRange + 1);

    }

    return array;

}

void FindElement() {

    int leftRange = 1;
    int rightRange = 100;
    int size = 10;
    int count = 0;

    int[] array = GenerateArray(size, leftRange, rightRange);
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");

    for(int i = 0; i < size; i++){

        if(array[i] >= 20 && array[i] <= 90){

            count++;

        }

    }

    System.Console.WriteLine(count);

}

FindElement();
