using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_2509_2nd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lab1: Write a C# program to print the multiplication table of a given number using the for loop.

            //Console.WriteLine("Enter the number : ");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{Number} * {i} = {Number * i}");
            //}
            //Console.ReadLine();


            //LAB2 : Write a C# program to display a right-angled triangle pattern using nested for loops.

            //Console.WriteLine("Enter the number of rows: ");
            //int Number_of_Rows = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < Number_of_Rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //LAB3: Write a C# program to calculate the sum of all even numbers between 1 and 100 using a while loop

            //int sum = 0;
            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    i += 1;

            //}
            //Console.WriteLine($"sum of even numbers between 1 and 100 is {sum}");
            //Console.ReadLine();


            //LAB4 : Write a C# program to print a multiplication table from 1 to 5 using nested while loops.

            //int i = 1;

            //while (i <= 5)
            //{
            //    int j = 1;
            //    while (j<=10)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //        j += 1;
            //    }
            //    Console.WriteLine();
            //    i += 1;
            //}
            //Console.ReadLine() ;


            //LAB5: Write a C# program to keep asking the user to enter a positive number and print it. The program
            // should stop when the user enters a negative number.

            //int Number;
            //do
            //{
            //    Console.WriteLine("Enter a positive number");
            //    Number = Convert.ToInt32(Console.ReadLine());
            //    if (Number > 0)
            //    {
            //        Console.WriteLine($"{Number} is positive ");

            //    }
            //    else if (Number == 0)
            //    {
            //        Console.WriteLine("neither positive nor negative ");
            //    }
            //}
            //while (Number >= 0);
            //{
            //    Console.WriteLine("The program has ended ");
            //    //return; 


            //}
            //Console.ReadLine();



            //lab6: Write a C# program to create a basic menu-driven calculator using nested do-while loops. The
            //calculator should continue to ask the user for two numbers and an operation(+, -, *, /) until the
            //user chooses to exit.
            //char Operator;
            //int First_Number;
            //int Second_Number;
            //char option;

            //do
            //{

            //    Console.WriteLine("Enter the first number");
            //    First_Number = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter the operator ( + - * / ) ");
            //    Operator = Convert.ToChar(Console.ReadLine());
            //    Console.WriteLine("Enter the second number");
            //    Second_Number = Convert.ToInt32(Console.ReadLine());
            //    if (Operator == '+')
            //    {
            //        Console.WriteLine($"{First_Number} {Operator} {Second_Number} = {First_Number + Second_Number}");
            //    }
            //    else if (Operator == '-')
            //    {
            //        Console.WriteLine($"{First_Number} {Operator} {Second_Number} = {First_Number - Second_Number}");
            //    }
            //    else if (Operator == '*')
            //    {
            //        Console.WriteLine($"{First_Number} {Operator} {Second_Number} = {First_Number * Second_Number}");
            //    }
            //    else if (Operator == '/')
            //    {
            //        if (Second_Number == 0)
            //        {
            //            Console.WriteLine("INVALID");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{First_Number} {Operator} {Second_Number} = {First_Number / Second_Number}");
            //        }
            //    }
            //    Console.WriteLine("exit or Conitinue (E/C)");
            //    option = Convert.ToChar(Console.ReadLine());
            //}
            //while (option != 'e' && option != 'E');
            //{
            //    Console.WriteLine("The user has chose to exit");

            //}
            //Console.ReadLine();



            //LAB7 : Write a C# program to print all numbers from 1 to 100. Use the continue statement to skip
            //numbers that are divisible by 3, and use the break statement to stop the loop if the number
            //exceeds 50.

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    else if (i > 50)
            //    {
            //        break;

            //    }
            //    else
            //    {
            //        Console.Write(i + " ");
            //    }

            //}
            //Console.ReadLine();

            //LAB8: Write a C# program to calculate the sum of all odd numbers between 1 and 100 using a for loop.
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"Sum of all odd numbers between 1 and 100 {sum}");
            //Console.ReadLine();

            //LAB9: Write a C# program to calculate the factorial of a given number using a while loop.
            //Console.WriteLine("Enter the number greater than 0 ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int Factorial = 1;
            //while (i <= num)
            //{
            //    Factorial *= i;
            //    i++;
            //}
            //Console.WriteLine($"factorial of {num} = {Factorial}");
            //Console.ReadLine();


            //LAB10: Write a C# program to print a number pyramid using a nested while loop. Example for 5 rows:
            //Console.WriteLine("Enter the number of rows : ");
            //int Number_of_Rows = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //for (int i=0; i<Number_of_Rows; i++)
            //{
            //    for (int j=0;j<=i;j++)
            //    {
            //        Console.Write(i + 1);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //Random Random = new Random();
            //Char Play_Again;

            //    int Random_Number = Random.Next(1, 101);
            //    Console.WriteLine("welcome to guess the random number game ");
            //    Console.WriteLine("The number to be guessed is between 1 and 100");
            //    Console.WriteLine("TRY IT OUT!!!");

            //do
            //{
            //    Console.WriteLine("Enter your Guess : ");
            //    int Guess = Convert.ToInt32(Console.ReadLine());
            //    if (Guess > Random_Number)
            //    {
            //        Console.WriteLine("OOPS TOO HIGH ");
            //        Console.WriteLine($"the answer is {Random_Number}");
            //    }
            //    else if (Guess < Random_Number)
            //    {
            //        Console.WriteLine("OOPS TOO LOWWW");
            //        Console.WriteLine($"the answer is {Random_Number}");
            //    }
            //    else if (Guess == Random_Number)
            //    {
            //        Console.WriteLine("CONGRATULATION!!! YOU WON THE GAME");
            //    }
            //    Console.WriteLine("Do you wish to try again : (y/n)");
            //    Play_Again = Convert.ToChar(Console.ReadLine());
            //}
            //while (Play_Again != 'n' && Play_Again != 'N');
            //    {
            //        Console.WriteLine("Thankyou for playing");
            //        Console.WriteLine("VISIT AGAIN");
            //    }


            //    Random random = new Random();
            //    bool playAgain = true;

            //    do
            //    {
            //        int targetNumber = random.Next(1, 101); // Generates a random number between 1 and 100
            //        int guess = 0;
            //        int attempts = 0;

            //        Console.WriteLine("Welcome to the 'Guess the Number' game!");
            //        Console.WriteLine("I have chosen a number between 1 and 100. Try to guess it!");

            //        do
            //        {
            //            Console.Write("Enter your guess: ");
            //            string input = Console.ReadLine();

            //            if (int.TryParse(input, out guess))
            //            {
            //                attempts++;
            //                if (guess < targetNumber)
            //                {
            //                    Console.WriteLine("Too low!");
            //                }
            //                else if (guess > targetNumber)
            //                {
            //                    Console.WriteLine("Too high!");
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"Congratulations! You guessed the number {targetNumber} in {attempts} attempts.");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Please enter a valid number.");
            //            }
            //        }
            //        while (guess != targetNumber);
            //        {

            //            Console.Write("Do you want to play again? (yes/no): ");
            //            string response = Console.ReadLine().ToLower();
            //            playAgain = response == "yes";

            //        }

            //    }
            //        while (playAgain);
            //    {

            //        Console.WriteLine("Thank you for playing!");
            //    }

            //Console.ReadLine();




            //LAB12: Write a C# program to create a simple calculator using a switch-case statement. The program
            //should handle addition, subtraction, multiplication, and division.

            //Console.WriteLine("Enter the first number");
            //int First_Number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the operator ( + - * / ) ");
            //Console.WriteLine("1. Addition -> +");
            //Console.WriteLine("2. Substraction -> -");
            //Console.WriteLine("3. Multiplication -> *");
            //Console.WriteLine("4. Division -> /");
            //char Operator = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Enter the second number");
            //int Second_Number = Convert.ToInt32(Console.ReadLine());
            //switch(Operator)
            //{
            //    case '+':
            //        Console.WriteLine($"The output is {First_Number + Second_Number}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"The output is {First_Number - Second_Number}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"The output is {First_Number * Second_Number}");
            //        break;
            //    case '/':
            //        if (Second_Number != 0)
            //        {
            //            Console.WriteLine($"The output is {First_Number + Second_Number}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("invalid");
            //        }
            //        break;

            //}
            //Console.ReadLine();


            //LAB13: Write a C# program that accepts a number from the user and calculates the sum of its digits using
            //a do -while loop.

            //Console.WriteLine("Enter the number : ");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //do
            //{
            //    sum += Number%10;
            //    Number /= 10;
            //}
            //while (Number > 0);
            //{
            //    Console.WriteLine($"sum of its digit is {sum}");
            //}
            //Console.ReadLine();

            //lab14: Write a C# program that accepts 10 numbers from the user and finds the largest number using a
            //for loop.
            //int[] Numbers = new int[10];
            //int temp;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("enter 10 numbers :" + (i + 1));
            //    Numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int x = 0; x < 10; x++)
            //{
            //    for (int y = x + 1; y < 10; y++)
            //    {
            //        if (Numbers[x] <= Numbers[y])
            //        {
            //            temp = Numbers[x];
            //            Numbers[x] = Numbers[y];
            //            Numbers[y] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine($"The larget element is {Numbers[0]}");

            //Console.ReadLine();

            //LAB15: Write a C# program to calculate the sum of squares of all numbers from 1 to a user-provided
            //number using a while loop.

            //Console.WriteLine("Enter the number : ");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //while (i <= Number)
            //{
            //    sum += (i * i);
            //    i++;
            //}
            //Console.WriteLine($"{sum} is the sum of square of numbers from 1 to {Number}");
            //Console.ReadLine();




            //LAB16: Write a C# program to simulate a countdown timer from 10 to 1 using a do-while loop, 
            //displaying each second.
            //int counter = 10;
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter--;
            //    Thread.Sleep(1000); 
            //} 
            //while (counter > 0);
            //{

            //    Console.WriteLine("Time's up!");
            //}
            //Console.ReadLine();



            //LAB17:Write a C# program to find and print the first multiple of 5 in a given list of numbers. Use the 
            //break statement to exit the loop once a multiple of 5 is found.
            //int size = 10;
            //int[] numbers = new int[size];
            //Console.WriteLine("Enter 10 values  :");
            //for (int j=0;j<size;j++)
            //{
            //    numbers[j] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Length; i++) {
            //    if (numbers[i] % 5 == 0) {
            //        Console.WriteLine($"{numbers[i]} is the first multiple of 5 in thegiven 10 values");
            //        break;
            //            }
            //    else {
            //        continue;
            //    }
            //}
            //Console.ReadLine();



            //LAB18: Write a C# program to print numbers from 1 to 20, but skip numbers that are divisible by 3 using 
            //the continue statement.
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();


            //LAB19: Write a C# program to check if a given number is a palindrome using a while loop.
            //Console.WriteLine("Enter the number to checked ");
            //int Number= Int32.Parse(Console.ReadLine());
            //int Original_Number = Number;
            //int Reverse_Number =0;
            //int Temp;
            //while (Number!=0)
            //{
            //    Temp = Number % 10;
            //    Reverse_Number=(Reverse_Number * 10) + Temp;
            //    Number = Number / 10;
            //}
            //if (Original_Number == Reverse_Number)
            //{
            //    Console.WriteLine($"{Original_Number} is a pallindrome");
            //}
            //else
            //{
            //    Console.WriteLine($"{Original_Number} is not a pallindrome");
            //}
            //Console.ReadLine();

            //LAB20: Write a C# program to calculate the average of positive numbers entered by the user. The 
            //program should stop when the user enters a negative number using a do -while loop.
            //int Average;
            //    int sum = 0;
            //    Console.WriteLine("Enter the size of number ");
            //    int size = Convert.ToInt32(Console.ReadLine());
            //    int[] numbers = new int[size];
            //    Console.WriteLine($"Enter {size} positive values  :");
            //    for (int j = 0; j < size; j++)
            //    {
            //        numbers[j] = Convert.ToInt32(Console.ReadLine());
            //        if (numbers[j] < 0)
            //        {
            //            Console.WriteLine("entered a negative value. ");
            //            break;
            //        }
            //        else
            //        {
            //            sum += numbers[j];
            //        }

            //    }
            //    int checksum = 0;
            //    for (int k=0; k < size; k++)
            //    {
            //        checksum += numbers[k];

            //    }

            //    do
            //    {
            //        int Average;
            //        if (checksum == sum)
            //        {
            //            Average = checksum / size;
            //            Console.WriteLine($"Average of the values is {Average}");
            //            continue;

            //        }
            //        Console.WriteLine("the answer found");

            //    }
            //    while (checksum == sum);
            //    {
            //        Console.WriteLine($"Therefore program is stopped");
            //    }
            //    Console.ReadLine();
            //}



            //LAB21: Write a C# program to reverse a given number using a do-while loop. 
            //Console.WriteLine("Enter the number to checked ");
            //int Number = Int32.Parse(Console.ReadLine());
            //int Original_Number = Number;
            //int Reverse_Number = 0;
            //int Temp;
            //do
            //{
            //    if (Number >= 0)
            //    {
            //        Temp = Number % 10;
            //        Reverse_Number = (Reverse_Number * 10) + Temp;
            //        Number = Number / 10;
            //    }


            //}
            //while (Number!=0);
            //{
            //    Console.WriteLine($"{Reverse_Number} is the reverse of {Original_Number}");
            //}
            //Console.ReadLine();


            //LAB22: Write a C# program that presents a menu to the user for various string operations: 
            //1.Reverse the string
            //2.Convert to uppercase
            //3.Convert to lowercase
            //4.Find the length of the string
            //Use a switch-case statement to implement this.
            //Console.WriteLine("Enter the string :");
            //string Str = Console.ReadLine();
            //Console.WriteLine("Enter the operation ");
            //Console.WriteLine("To choose the operation enter the number of the operation between 1, 2, 3 and 4");
            //Console.WriteLine("1. Reverse the string");
            //Console.WriteLine("2. Convert to uppercase ");
            //Console.WriteLine("3.Convert to lowercase");
            //Console.WriteLine("4. Find the length of the string ");
            //int Operation = Convert.ToInt32(Console.ReadLine());
            //switch (Operation)
            //{
            //    case 1:

            //        //string Reversed_str;
            //        string Reversed_str = string.Empty;
            //        for (int i = Str.Length - 1; i >= 0; i--)
            //        {
            //            Reversed_str += Str[i];
            //        }
            //        Console.WriteLine($"reversed string is {Reversed_str}");
            //        break;
            //    case 2:
            //        string Output_string = Str.ToUpper();
            //        Console.WriteLine($"{Output_string} is the upper case");
            //        break;
            //    case 3:
            //        string lower_str = Str.ToLower();
            //        Console.WriteLine($"{lower_str} is the lower case");
            //        break;
            //    case 4:
            //        int length_of_string = Str.Length;
            //        Console.WriteLine($"{length_of_string} is the length");
            //        break;
            //}
            //Console.ReadLine();


            //LAB23: Write a C# program to print numbers from 1 to 50 but skip numbers that are divisible by 4 using 
            //the continue statement.
            //for (int i = 0; i <= 50; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.Write(i);
            //    }

            //}
            //Console.ReadLine();


            //LAB24: Write a C# program to print the first 10 numbers in the Fibonacci sequence using a for loop.
            //int firstNumber = 0, secondNumber = 1, nextNumber;
            //Console.WriteLine("The first 10 numbers in the Fibonacci sequence are:");
            //Console.Write($"{firstNumber} {secondNumber} ");
            //for (int i = 2; i < 10; i++)
            //{
            //    nextNumber = firstNumber + secondNumber;
            //    Console.Write(nextNumber + " ");
            //    firstNumber = secondNumber;
            //    secondNumber = nextNumber;
            //}
            //Console.ReadLine();


            //LAB25: Write a C# program to find all Armstrong numbers between 1 and 500 using a while loop. (An 
            //Armstrong number is a number that is equal to the sum of the cubes of its digits).
            //int number = 1;
            //while (number <= 500)
            //{
            //    int sumOfCubes = 0;
            //    int temp = number;
            //    int digits = number;
            //    while (digits > 0)
            //    {
            //        int digit = digits % 10;
            //        sumOfCubes += digit * digit * digit;
            //        digits /= 10;
            //    }

            //    if (sumOfCubes == number)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    number++;
            //}
            //Console.ReadLine();


            //LAB26: Write a C# program to create a menu-driven system for number conversions: 
            //1.Binary to Decimal
            //2.Decimal to Binary
            //3.Decimal to Hexadecimal
            //Use a switch-case statement to implement this.
            //Console.WriteLine("Menu:");
            //Console.WriteLine("1. Binary to Decimal");
            //Console.WriteLine("2. Decimal to Binary");
            //Console.WriteLine("3. Decimal to Hexadecimal");
            //Console.WriteLine("4. Exit");
            //Console.Write("Enter your choice: ");
            //int choice = int.Parse(Console.ReadLine());
            //switch (choice)
            //{
            //    case 1:
            //        Console.Write("Enter a binary number: ");
            //        string binary = Console.ReadLine();
            //        int decimalValue = Convert.ToInt32(binary, 2);
            //        Console.WriteLine($"Decimal: {decimalValue}");
            //        break;

            //    case 2:
            //        Console.Write("Enter a decimal number: ");
            //        int decimalNumber = int.Parse(Console.ReadLine());
            //        string binaryValue = Convert.ToString(decimalNumber, 2);
            //        Console.WriteLine($"Binary: {binaryValue}");
            //        break;

            //    case 3:
            //        Console.Write("Enter a decimal number: ");
            //        int decimalNum = int.Parse(Console.ReadLine());
            //        string hexValue = Convert.ToString(decimalNum, 16).ToUpper();
            //        Console.WriteLine($"Hexadecimal: {hexValue}");
            //        break;

            //    case 4:
            //        Console.WriteLine("Exiting.......");
            //        Thread.Sleep(1000);
            //        return;

            //    default:
            //        Console.WriteLine("Invalid choice. Please try again.");
            //        break;
            //}

            //Console.WriteLine();
            //Console.ReadLine();



            //LAB27: Write a C# program to reverse a given string using a for loop. 
            //Console.WriteLine("Enter the string :");
            //string Str = Console.ReadLine();
            //string Reversed_str = string.Empty;
            //for (int i = Str.Length - 1; i >= 0; i--)
            //{
            //    Reversed_str += Str[i];
            //}
            //Console.WriteLine($"reversed string is {Reversed_str}");
            //Console.ReadLine();


            //LABB28: Write a C# program to count the number of vowels and consonants in a given string using a for 
            //loop.
            //Console.WriteLine("Enter the string :");
            //string String = Console.ReadLine();
            //int numberofVowels = 0;
            //int numberofConsonants = 0;
            //string Str = String.ToLower(); 

            //for (int i = Str.Length - 1; i >= 0; i--)
            //{
            //    if (Str[i] == 'a' || Str[i] == 'e' || Str[i] == 'i' || Str[i] == 'o' || Str[i] == 'u')
            //    {
            //        numberofVowels++;
            //    }
            //    else
            //    {
            //        numberofConsonants++;
            //    }
            //}
            //Console.WriteLine($"{numberofConsonants} is the total number of consonants ");
            //Console.WriteLine($"{numberofVowels} is the total number of vowels");
            //Console.ReadLine();


            //LAB29: Write a C# program to find the maximum and minimum of 5 numbers entered by the user using a 
            //for loop.
            //int temp;
            //int[] Numbers = new int[5];
            //Console.WriteLine("Enter 5 Values : ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = 0; j < 5; j++)
            //{
            //    for (int k = j + 1; k < 5; k++)
            //    {
            //        if (Numbers[j] > Numbers[k])
            //        {
            //            temp = Numbers[j];
            //            Numbers[j] = Numbers[k];
            //            Numbers[k] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine($"maximum = {Numbers[5 - 1]}  Minimum = {Numbers[0]}");
            //Console.ReadLine();


            //LAB30: Write a C# program to count the number of digits in a given number using a while loop.
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }
            Console.WriteLine("Number of digits: " + count);
            Console.ReadLine();
        }
    }
}
