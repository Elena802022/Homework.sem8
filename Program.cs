// Задача 54. Написать программу, которая упорядочивает элементы массива по убыванию.
/*
Console.WriteLine("Enter the number of rows of the array: ");
int rows=int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number of columns of the array: ");
int columns=int.Parse(Console.ReadLine()!);
int[,]array=GetArray(rows, columns, 0, 10);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);

int[,]GetArray(int m, int n, int min, int max)
{
    int[,]result=new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
         result[i,j]=new Random().Next(min,max+1);
        }
    }
    return result;
}

void PrintArray (int[,]inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1);j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int t=j+1; t<array.GetLength(1); t++)
            {
                if(array[i,t]>array[i,j])
                {
                    int temp=array[i,j];
                    array[i,j]=array[i,t];
                    array[i,t]=temp;
                }
            }
        }
    }
}
*/
/*
//Задача 56. Задайте прямоугольный двумерный массив. Напищите программу, которая будет находить строку с наименьшей суммой элементов. 
Console.WriteLine("Enter the number of rows of the array: ");
int rows=int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number of columns of the array: ");
int columns=int.Parse(Console.ReadLine()!);
int[,]array=GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($"The row with the smallest sum - {GetRowNumber(array)} ");

int[,]GetArray(int m, int n, int min, int max)
{
    int[,] result= new int [m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result [i,j]=new Random().Next(min,max+1);
        }
    }
    return result;
}

void PrintArray(int[,]inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
{
    for(int j=0; j<inArray.GetLength(1); j++)
    {
        Console.Write($"{inArray[i,j]} ");
    }
    Console.WriteLine();
}
}

int GetRowNumber (int[,]array)
{
    int row=0;
    int minsum=0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        minsum=minsum+array[0,i];
    }
    for(int i=1; i<array.GetLength(0);i++)
    {
        int sum=0;
        for(int j=0; j<array.GetLength(1); j++)
        {
            sum=sum+array[i,j];
        }
        if (minsum>sum)
        {
            minsum=sum;
            row=i;
        }
    }
    return row;
}
*/
// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение 2х матриц.
/*
Console.Write("Enter the number of rows of the first array: ");
int rowsA=int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns of the first array: ");
int columnsA=int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of rows of the second array: ");
int rowsB=int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns of the second array: ");
int columnsB=int.Parse(Console.ReadLine()!);
if (columnsA != rowsB)
{
    Console.WriteLine("Such matrices cannot be multiplied!");
    return;
}

int[,]A=GetArray(rowsA, columnsA, 0, 10);
int[,]B=GetArray(rowsB, columnsB, 0, 10);
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(GetMultiplicationMatrix(A,B));

int[,]GetArray(int m, int n, int min, int max)
{
    int[,] result= new int [m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result [i,j]=new Random().Next(min,max+1);
        }
    }
    return result;
}

void PrintArray(int[,]inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
{
    for(int j=0; j<inArray.GetLength(1); j++)
    {
        Console.Write($"{inArray[i,j]} ");
    }
    Console.WriteLine();
}
}

int [,] GetMultiplicationMatrix(int[,]arrayA, int[,]arrayB)
{
    int[,]arrayC=new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for(int i=0; i<arrayA.GetLength(0);i++)
    {
        for(int j=0; j<arrayB.GetLength(1); j++)
        {
            for(int k=0; k<arrayA.GetLength(1); k++)
            {
                arrayA[i,j]+=arrayA[i,k]*arrayB[k,j];
            }
        }
    }
    return arrayC;
}
*/