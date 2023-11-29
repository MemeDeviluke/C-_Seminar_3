// Задание 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random random = new Random();

    for(int i = 0; i < size; i++){

        array[i] = random.Next(leftRange, rightRange + 1);

    }

    return array;

}

void CheckEvenNumbers() {

    int leftRange = 1;
    int rightRange = 100;
    int size = 10;
    int count = 0;

    int[] array = GenerateArray(size, leftRange, rightRange);
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");

    for(int i = 0; i < size; i++){

        if(array[i] % 2 == 0){

            count++;

        }

    }

    System.Console.WriteLine(count);

}


CheckEvenNumbers();
