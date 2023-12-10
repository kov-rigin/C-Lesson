//функцию, которая обнулит чётные элементы массива
void ZeroElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            array[i] = 0;
        }
    }
}
void PrintArray(int[] array)
{
    foreach (int e in array)
    {
        Console.Write($"{e} ");
    }
}
int[] array = { 2, 5, 6, 8, 9, 3, 1, 6 };
ZeroElements(array);
PrintArray(array);
