//Assignment 1. Write C# programs on Matrix addition, Matrix Multiplication and Matrix 
//Transpose.



//using System;
//class MatrixOperations
//{
//    public static void Main()
//    {
//        int[,] matrixA = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 } };
//        int[,] matrixB = {
//            { 9, 8, 7 },
//            { 6, 5, 4 },
//            { 3, 2, 1 } }; Console.WriteLine("Matrix A:");
//        PrintMatrix(matrixA); Console.WriteLine("Matrix B:");
//        PrintMatrix(matrixB);
//        // Matrix Addition
//        int[,] additionResult = AddMatrices(matrixA, matrixB);
//        Console.WriteLine("Matrix Addition:");
//        PrintMatrix(additionResult);
//        // Matrix Multiplication
//        int[,] multiplicationResult = MultiplyMatrices(matrixA, matrixB);
//        Console.WriteLine("Matrix Multiplication:");
//        PrintMatrix(multiplicationResult);
//        // Matrix Transpose
//        int[,] transposeResult = TransposeMatrix(matrixA);
//        Console.WriteLine("Matrix Transpose:");
//        PrintMatrix(transposeResult);
//        Console.ReadLine();
//    }
//    public static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
//    {
//        int rows = matrixA.GetLength(0);
//        int cols = matrixA.GetLength(1);
//        int[,] result = new int[rows, cols];
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                result[i, j] = matrixA[i, j] + matrixB[i, j];
//            }
//        }
//        return result;
//    }
//    public static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
//    {
//        int rowsA = matrixA.GetLength(0);
//        int colsA = matrixA.GetLength(1);
//        int colsB = matrixB.GetLength(1);
//        int[,] result = new int[rowsA, colsB];
//        for (int i = 0; i < rowsA; i++)
//        {
//            for (int j = 0; j < colsB; j++)
//            {
//                for (int k = 0; k < colsA; k++)
//                {
//                    result[i, j] += matrixA[i, k] * matrixB[k, j];
//                }
//            }
//        }
//        return result;
//    }
//    public static int[,] TransposeMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);
//        int[,] result = new int[cols, rows];
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                result[j, i] = matrix[i, j];
//            }
//        }
//        return result;
//    }
//    public static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//=======================================================================================================================================================================


//Assignment 2. Write C# programs to sort an array using bubble sort and insertion sort. 

class Program
{
    //    static void Main()
    //    {
    //        Console.WriteLine("Enter the number of elements in the array:");
    //        int n = int.Parse(Console.ReadLine());
    //        int[] array = new int[n];
    //        Console.WriteLine("Enter the elements of the array:");
    //        for (int i = 0; i < n; i++)
    //        {
    //            Console.Write($"Element {i + 1}: ");
    //            array[i] = int.Parse(Console.ReadLine());
    //        }
    //        Console.WriteLine("The array :");
    //        PrintArray(array);
    //        int[] bubbleSortedArray = (int[])array.Clone();
    //        BubbleSort(bubbleSortedArray);
    //        int[] insertionSortedArray = (int[])array.Clone();
    //        InsertionSort(insertionSortedArray);
    //        Console.WriteLine("Array sorted using Bubble Sort:");
    //        PrintArray(bubbleSortedArray);
    //        Console.WriteLine("Array sorted using Insertion Sort:");
    //        PrintArray(insertionSortedArray);
    //    }

    //    static void BubbleSort(int[] array)
    //    {
    //        int n = array.Length;
    //        for (int i = 0; i < n - 1; i++)
    //        {
    //            for (int j = 0; j < n - i - 1; j++)
    //            {
    //                if (array[j] > array[j + 1])
    //                { // Swap array[j] and array[j + 1]
    //                    int temp = array[j];

    //                    array[j] = array[j + 1];
    //                    array[j + 1] = temp;
    //                }
    //            }
    //        }
    //    }
    //    static void InsertionSort(int[] array)
    //    {
    //        int n = array.Length;
    //        for (int i = 1; i < n; i++)
    //        {
    //            int key = array[i];
    //            int j = i - 1;
    //            while (j >= 0 && array[j] > key)
    //            {
    //                array[j + 1] = array[j];
    //                j = j - 1;
    //            }
    //            array[j + 1] = key;
    //        }

    //    }
    //    static void PrintArray(int[] array)
    //    {
    //        foreach (int element in array)
    //        {
    //            Console.Write(element + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //========================================================================================================================================================================

    //Assignment 3. Write C# programs to search an array using linear search and binary 
    //search.
    static void Main()
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The array :");
        PrintArray(array);
        Console.WriteLine("Enter the element to be searched in linear search");
        int Element = int.Parse(Console.ReadLine());
        int LinearSearchResult = LinearSearch(array, Element);
        if(LinearSearchResult != -1)
        {
            Console.WriteLine($"{Element} found after linear search at idex {LinearSearchResult}");
        }
        else
        {
            Console.WriteLine($"{Element} not found after linear search");
        }
        int BinarySearchResult = BinarySearch(array, Element);
        if (BinarySearchResult == -1)
        {
            Console.WriteLine($"{Element} is not found after Binary search");

        }
        else
        {
            Console.WriteLine($"{Element}  found after binary search at index {BinarySearchResult}");
        }

    }
    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

    }
    static int LinearSearch( int[] array, int Element)
    {
        
        for (int i = 0;i<array.Length;i++)
        {
            if (Element== array[i])
            {
                return i;
            }
        }
        return -1;
    }
    static int BinarySearch(int[] array, int Element)
    {
        Array.Sort(array);
        int low = 0;
        int high = array.Length - 1;
        while (low <= high)
        {
            int mid = (low + high)/2;
            if (array[mid]==Element)
            {
                return mid;
            }
            else if (array[mid] < Element)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return -1;

    }
}





