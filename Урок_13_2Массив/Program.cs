                     //
string[,] table = new string [25, 25];
//String.Empty
// table[0, 0] table[0, 1] .... table[0, 4]
// table[1, 0] table[1, 1] .... table[1, 4]

/*table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int colum = 0; colum < 5; colum++)
}{
Console.WriteLine($"-{table[rows, colum]}-");
}*/





void  PrintImage(int[,] matr)
{
for(int i = 0; i< matr.GetLength(0); i++)
{
    for(int j = 0; j< matr.GetLength(1); j++)
    {
//Console.Write($"{matr[i, j]} ");
if(matr[i,j] == 0) Console.Write($" ");
else Console.Write($"+");
    }
    Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for( int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 2); //[1, 10)
        }
    }
}


int[,] matrix = new int[25, 25];

void FillImage( int row, int col)
{
    if(matrix[row, col] == 0)
    {
matrix[ row, col]= 1;
FillImage( row-1, col);
FillImage( row, col-1);
FillImage( row+1, col);
FillImage( row, col+1);
    }
}


//PrintArray(matrix);
FillArray(matrix);
//Console.WriteLine();
//PrintArray(matrix);
PrintImage(matrix);
Console.WriteLine();
FillImage(13, 13);
PrintImage(matrix);

