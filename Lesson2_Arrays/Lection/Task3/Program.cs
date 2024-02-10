// int N = 10;
int[] array = {2, 4, 7, 5, 8, 1, 9, 4, 7, 5};
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i++;
}