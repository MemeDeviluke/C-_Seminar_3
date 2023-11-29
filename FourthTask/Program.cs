//Задание 4: Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
//          Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

int GetSingleDigitNumber(int number)
{

    int singleDigit = number % 10;

    return singleDigit;

}

int GetArraySize(int number)
{
    int size = 0;
    while(number > 0)
    {

        int sinDigit = GetSingleDigitNumber(number);
        number = number - sinDigit;
        number = number / 10;
        size++;
    }

    return size;
}


void SplitNumber()
{

    System.Console.Write("Введите число в диапазоне от 1 до 100 000, включительно:");
    int number = Convert.ToInt32(Console.ReadLine());

    while(number < 1 || number > 100000)
    {
        System.Console.WriteLine("Ваше число вышло из диапазона");
        System.Console.Write("Повторите ввод:");
        number = Convert.ToInt32(Console.ReadLine());
    }

    int size = GetArraySize(number);
    int[] array = new int[size];

    for(int i = size - 1; i >= 0; i--)
    {
        int singDigit = GetSingleDigitNumber(number);    
        array[i] = singDigit;
        number /= 10;
    }

    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

SplitNumber();