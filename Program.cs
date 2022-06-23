void PrintAraay(int[,] matrix)

{
    for (int i=0; i < matrix.GetLength(0); i++);
    {
        for (int j=0; j < matrix.GetLength(0); j++);
        {
            Console.Write($"{matrix[i; j]} '");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int [3, 4];
PrintAraay(matrix);
