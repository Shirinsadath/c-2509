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

using System.ComponentModel;
using System.Globalization;

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
    //static void Main()
    //{
    //    Console.WriteLine("Enter the number of elements in the array:");
    //    int n = int.Parse(Console.ReadLine());
    //    int[] array = new int[n];
    //    Console.WriteLine("Enter the elements of the array:");
    //    for (int i = 0; i < n; i++)
    //    {
    //        Console.Write($"Element {i + 1}: ");
    //        array[i] = int.Parse(Console.ReadLine());
    //    }
    //    Console.WriteLine("The array :");
    //    PrintArray(array);
    //    Console.WriteLine("Enter the element to be searched in linear search");
    //    int Element = int.Parse(Console.ReadLine());
    //    int LinearSearchResult = LinearSearch(array, Element);
    //    if(LinearSearchResult != -1)
    //    {
    //        Console.WriteLine($"{Element} found after linear search at idex {LinearSearchResult}");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"{Element} not found after linear search");
    //    }
    //    int BinarySearchResult = BinarySearch(array, Element);
    //    if (BinarySearchResult == -1)
    //    {
    //        Console.WriteLine($"{Element} is not found after Binary search");

    //    }
    //    else
    //    {
    //        Console.WriteLine($"{Element}  found after binary search at index {BinarySearchResult}");
    //    }

    //}
    //static void PrintArray(int[] array)
    //{
    //    foreach (int element in array)
    //    {
    //        Console.Write(element + " ");
    //    }
    //    Console.WriteLine();

    //}
    //static int LinearSearch( int[] array, int Element)
    //{

    //    for (int i = 0;i<array.Length;i++)
    //    {
    //        if (Element== array[i])
    //        {
    //            return i;
    //        }
    //    }
    //    return -1;
    //}
    //static int BinarySearch(int[] array, int Element)
    //{
    //    Array.Sort(array);
    //    int low = 0;
    //    int high = array.Length - 1;
    //    while (low <= high)
    //    {
    //        int mid = (low + high)/2;
    //        if (array[mid]==Element)
    //        {
    //            return mid;
    //        }
    //        else if (array[mid] < Element)
    //        {
    //            low = mid + 1;
    //        }
    //        else
    //        {
    //            high = mid - 1;
    //        }
    //    }
    //    return -1;

    //}

    //===========================================================================================================================================================

    //Assignment 4. Array Calculations: write C# programs for finding median, mode value, 
    //highest, second highest and duplicate elements in an array.

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter the number elements in the array");
    //    int n = int.Parse(Console.ReadLine());
    //    int[] array = new int[n];
    //    Console.WriteLine("Enter the elements of the array:");
    //    for (int i = 0; i < n; i++)
    //    {
    //        Console.Write($"Element {i + 1}: ");
    //        array[i] = int.Parse(Console.ReadLine());
    //    }
    //    Console.WriteLine("The array :");
    //    PrintArray(array);
    //    Console.WriteLine($"Median: {FindMedian(array, n)}");
    //    Console.WriteLine($"Mode: {FindMode(array)}");
    //    Console.WriteLine($"Highest: {FindHighest(array,n)}");
    //    Console.WriteLine($"Second Highest: {FindSecondHighest(array, n)}");
    //    var duplicates = FindDuplicates(array);
    //    Console.WriteLine("Duplicates:");
    //    foreach (var item in duplicates)
    //    {
    //        Console.WriteLine(item);
    //    }

    //}
    //static void PrintArray(int[] array)
    //{
    //    foreach (int element in array)
    //    {
    //        Console.Write(element + " ");
    //    }
    //    Console.WriteLine();

    //}
    //static double FindMedian(int[] array, int n)
    //{
    //    if ( n%2 == 0 )
    //    {
    //        return array[(n+1)/2];
    //    }
    //    else
    //    {
    //        return (array[n/2] + array[(n/2)+1])/2;
    //    }
    //}
    //static int FindMode(int[] array)
    //{
    //    return array.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;
    //}
    //static int FindHighest(int[] array, int n)
    //{
    //    Array.Sort(array);
    //    return array[n - 1];
    //}

    //static int FindSecondHighest(int[] array, int n)
    //{
    //    Array.Sort(array);
    //    return array[n - 2];
    //}
    //static List<int> FindDuplicates(int[] array)
    //{
    //    return array.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
    //}

    //=====================================================================================================================================================================================

    //Assignment 5. Write a C# programs to count vowels, consonants and special characters.

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter a string:");
    //    string input = Console.ReadLine();
    //    input.ToLower();
    //    int vowelCount = 0;
    //    int consonantCount = 0;
    //    int specialCharCount = 0; 
    //    foreach (char c in input) 
    //    {

    //        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c== 'u') 
    //        {
    //            vowelCount++; 
    //        }
    //        else if ((c >= 'a' && c <= 'z'))
    //        {
    //            consonantCount++;
    //        }
    //        else if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
    //        {
    //            specialCharCount++; 
    //        }
    //    }
    //    Console.WriteLine($"Vowels: {vowelCount}"); 
    //    Console.WriteLine($"Consonants: {consonantCount}");
    //    Console.WriteLine($"Special Characters: {specialCharCount}");
    //}

    //==========================================================================================================================
    //static void Main()
    //{
    //    Console.WriteLine("Enter a string:");
    //    string input = Console.ReadLine();
    //    string reversedString = ReverseString(input);
    //    Console.WriteLine($"Reversed string: {reversedString}");
    //}
    //static string ReverseString(string input) 
    //{
    //    char[] charArray = input.ToCharArray();
    //    Array.Reverse(charArray);
    //    return new string(charArray);
    //}

    //====================================================================================================================================================

    //Assignment 7. Write a C# program to find substring occurrence within a main string. 

    //static void Main()
    //{
    //    Console.WriteLine("Enter the main string:");
    //    string mainString = Console.ReadLine(); 
    //    Console.WriteLine("Enter the substring to find:"); 
    //    string substring = Console.ReadLine();
    //    int occurrenceCount = FindSubstring(mainString, substring);
    //    Console.WriteLine($"The substring '{substring}' occurs {occurrenceCount} times in the main string.");
    //}
    //static int FindSubstring(string mainString, string substring)
    //{
    //    int count = 0;
    //    int index = 0;
    //    while ((index = mainString.IndexOf(substring, index)) != -1)
    //    {
    //        count++;
    //        index += substring.Length;

    //    } 
    //    return count;

    //}

    //=======================================================================================================================================

    //Assignment 8. Write a C# program to convert string to uppercase, lowercase, and title case. 

    //static void Main()
    //{
    //    Console.WriteLine("Enter a string:");
    //    string input = Console.ReadLine();
    //    // Convert to uppercase
    //    string upperCase = input.ToUpper();
    //    Console.WriteLine("Uppercase: " + upperCase);
    //    // Convert to lowercase
    //    string lowerCase = input.ToLower();
    //    Console.WriteLine("Lowercase: " + lowerCase);
    //    // Convert to title case
    //    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
    //    string titleCase = textInfo.ToTitleCase(input.ToLower());  
    //    Console.WriteLine("Title Case: " + titleCase);
    //}

    //=============================================================================================================================
    //Assignment 9. Write a C# program to remove whitespace from a string. 
    //static void Main()
    //{
    //    Console.WriteLine("Enter a string:");
    //    string input = Console.ReadLine();
    //    // Remove whitespace
    //    string withoutWhitespace = input.Replace(" ", ""); 
    //    Console.WriteLine("String without whitespace: " + withoutWhitespace);
    //}
    //====================================================================================================================================================

    //Assignment 10. Write a C# program to replace all occurrences of a substring.
    //static void Main()
    //{
    //    Console.WriteLine("Enter the main string:");
    //    string mainString = Console.ReadLine();
    //    Console.WriteLine("Enter the substring to replace:"); 
    //    string oldSubstring = Console.ReadLine(); 
    //    Console.WriteLine("Enter the new substring:");
    //    string newSubstring = Console.ReadLine();

    //    string resultString = mainString.Replace(oldSubstring, newSubstring);
    //    Console.WriteLine("String after replacement:");
    //    Console.WriteLine(resultString);
    //}

    //================================================================================================================================================
    //Assignment 11. Write a C# program to find the longest word in a sentence. 

    //static void Main()
    //{
    //    Console.WriteLine("Enter a sentence:"); 
    //    string sentence = Console.ReadLine();
    //    string longestWord = FindLongestWord(sentence); 
    //    Console.WriteLine($"The longest word is: {longestWord}"); 
    //}
    //static string FindLongestWord(string sentence) 
    //{
    //    string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    //    string longestWord = ""; 
    //    foreach (string word in words)
    //    {
    //        if (word.Length > longestWord.Length)
    //        { 
    //            longestWord = word; 
    //        }
    //    }
    //    return longestWord;
    //}
    //======================================================================================================================
    //Assignment 12. Write a C# program to count words in a sentence. 
    //static void Main()
    //{
    //    Console.WriteLine("Enter a sentence:");
    //    string sentence = Console.ReadLine();
    //    int wordCount = CountWords(sentence);
    //    Console.WriteLine($"The number of words in the sentence is: {wordCount}");
    //}
    //static int CountWords(string sentence)
    //{
    //    if (string.IsNullOrWhiteSpace(sentence))
    //    {
    //        return 0;
    //    }
    //    string[] words = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
    //    int count = 0; 
    //    foreach (string word in words)
    //    {
    //        count++; 
    //    }
    //    return count;
    //}

    //===========================================================================================================================
    //Assignment 13. Write a C# program to remove duplicate characters from a string.


    //static void Main()
    //{
    //    Console.WriteLine("Enter a string:");
    //    string input = Console.ReadLine();
    //    string result = RemoveDuplicates(input); 
    //    Console.WriteLine("String after removing duplicates:");
    //    Console.WriteLine(result);
    //}
    //static string RemoveDuplicates(string input) 
    //{
    //    string result = ""; 
    //    foreach (char c in input)
    //    {
    //        if (!result.Contains(c)) 
    //        {
    //            result += c; 
    //        }
    //    }
    //    return result;
    //    }

    //==================================================================================================================================
    //Assignment 14. Write a C# program to check if two strings are anagrams.
    //static void Main() 
    //{
    //    Console.WriteLine("Enter the first string:");
    //    string str1 = Console.ReadLine(); 
    //    Console.WriteLine("Enter the second string:");
    //    string str2 = Console.ReadLine();
    //    bool areAnagrams = CheckAnagrams(str1, str2); 
    //    if (areAnagrams) 
    //    {
    //        Console.WriteLine("The strings are anagrams."); 
    //    }
    //    else 
    //    {
    //        Console.WriteLine("The strings are not anagrams.");
    //    }
    //}
    //static bool CheckAnagrams(string str1, string str2)
    //{
    //    char[] charArray1 = str1.ToLower().ToCharArray();
    //    char[] charArray2 = str2.ToLower().ToCharArray();
    //    Array.Sort(charArray1); Array.Sort(charArray2);
    //    return new string(charArray1) == new string(charArray2);
    //}

    //=================================================================================================================

    //Assignment 15. Write a C# program to find the frequency of each character in a string.
}





