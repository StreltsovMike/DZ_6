//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


int PositivNumberCounter(int arraySize)
{
    int[] array = new int[arraySize];
    int positivCount = 0;
    for (int count = 0; count < arraySize; count++)
    {
        Console.WriteLine("Введите число : ");
        array[count] = Convert.ToInt32(Console.ReadLine());
        if(array[count]>0)
        {
            positivCount++;
        }
    }
    return positivCount;
}

Console.WriteLine("Введите количество чисел : ");
int amountOfNumbers= Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Положительных - {PositivNumberCounter(amountOfNumbers)}");