void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index++] = new Random ().Next (1, 10);
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
      Console.WriteLine(col[position]);
      position++;  
    }
}

int Indexof(int[] colletction, int find)
{
    int count = colletction.Length;
    int index = 0;
    int position = -1;
    

    while (index < count)
    {
        if (colletction[index] == find)
        {
position = index;
break;
        }
        index++;
    }
return position;
}
int [] array = new int [10];

FillArray(array);
PrintArray (array);
Console.WriteLine();

int pos = Indexof(array, 456);
Console.WriteLine(pos);
