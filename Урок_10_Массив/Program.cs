int [] array = {1,12,4,14,15,16,4,17,21};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index]== find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
