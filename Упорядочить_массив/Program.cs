int[] arr = {1, 2, 3, 4, 5, 6,3, 1, 4, 5, 6};

void PrintArray(int[] array)
{
    int count = array.Length;
    for( int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();

}

void Sort (int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
  
for( int j = i + 1 ; j < array.Length; j++)
{
if( array[j] < array[min]) min = j;
}

        int temp = array[i];
        array[i] = array[min];
        array[min]= temp;
    }
}

PrintArray(arr);
Sort(arr);

PrintArray(arr);
