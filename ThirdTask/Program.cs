// Задание 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] GenerateArray(int size)
{
    double[] array = new double[size];
    Random random = new Random();

    for(int i = 0; i < size; i++){

        array[i] = Math.Round(random.Next(0, 10) + random.NextDouble(), 2);

    }

    return array;

}

double FindMax(double[] array)
{
    double max = 0;

    for (int i = 0; i < array.Length; i++)
    {

        if(max < array[i])
        {

            max = array[i];

        }

    }

    return max;
}

double FindMin(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {

        if(min > array[i])
        {

            min = array[i];

        }

    }

    return min;
}

void FindDifference()
{

    System.Console.Write("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());

    double[] array = GenerateArray(size);

    System.Console.WriteLine("[" + string.Join(", ", array) + "]");

    double max = FindMax(array);
    double min = FindMin(array);

    double diff = max - min;

    System.Console.WriteLine($"Разница между: {max} и {min} равна {diff}");
}

FindDifference();