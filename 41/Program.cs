// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0;

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}




void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] -> ");
    Console.WriteLine($"{count}");

         
}

Console.Write("Ввидите число элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(num, -10, 10);

//int count = 0;

for (int i = 0; i < num; i++)
{
    if(array[i] > 0) count++;
}



PrintArray(array);

//Console.WriteLine($"{CreateArrayRndInt}");
