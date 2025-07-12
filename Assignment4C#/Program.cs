using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Functions
{
    internal class Program
    {
        #region Question1 Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.



        #region 1-Passing By Value
        static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region 2-Passing By Reference
        static void SwapRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #endregion

        #region Question2 Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example


        #region 1-Passing By Value

        //static void Arr1(int[] arr)
        //{
        //    if (arr == null)
        //    {
        //        return;
        //    }
        //    arr[0] = 100;
        //    arr = new int[] { 1, 2, 3, 4 };

        //}

        #endregion

        #region 2-Passing By Reference

        //static void Arr2(ref int[] arr)
        //{
        //    if (arr == null)
        //    {
        //        return;
        //    }
        //    arr[0] = 100;
        //    arr = new int[] { 5, 6, 7, 8 };

        //}
        #endregion

        #endregion

        #region Question 3 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

        //static void Sum_Sub(int X, int Y, out int Sum, out int Sub)
        //{
        //    Sum = X + Y;
        //    Sub = X - Y;
        //}

        #endregion

        #region Question 4 Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //static int SumOfDigit(int n)
        //{
        //    int sum = 0;
        //    while (n != 0)
        //    {
        //        sum += n % 10;
        //        n /= 10;

        //    }
        //    return sum;
        //}

        #endregion

        #region Question 5 Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not:

        //static bool IsPrime(int n)
        //{
        //    if (n < 2)
        //        return false;
        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}



        #endregion

        #region Question 6 Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        //static void minmaxarray(int[] arr, ref int max, ref int min)
        //{

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (max < arr[i])
        //            max = arr[i];
        //        else if (min > arr[i])
        //            min = arr[i];
        //    }
        //}


        #endregion

        #region Question 7 Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

        //static long factorial(int num)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        #endregion

        #region Question 8 Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

        //static string ChangeChar(string text, int index, char ch)
        //{
        //    text = text.Remove(index, 1);
        //    text = text.Insert(index, ch.ToString());
        //    return text;

        //}


        #endregion

        #region Question 9  Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity tableof size n* n.

        //static void IdentityMatrix(int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (i == j)
        //                Console.Write("1 ");
        //            else
        //                Console.Write("0 ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        #endregion

        #region Question 10 Write a program in C# Sharp to find the sum of all elements of the array.

        //static int SumArray(params int[] Arr)
        //{
        //    int Sum = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];

        //    }
        //    return Sum;
        //}

        #endregion

        #region QUESTION 11 Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.





        #endregion

        #region Question 12 Write a program in C# Sharp to find maximum and minimum element in an  array

        //static void minmaxarray(int[] arr, out int max,out  int min)
        //{
        //    max = arr[0];
        //    min = arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (max < arr[i])
        //            max = arr[i];
        //        else if (min > arr[i])
        //            min = arr[i];
        //    }
        //}



        #endregion

        #region  Question 14  Consider an Array of Integer values with size N, having values as in this Example.



        //static int FindMaxDistance(int[] arr)
        //{

        //    int maxDistance = arr.Length; 

        //    return maxDistance;

        //}
        #endregion

        #region Question 17 Write a Program to Print One Dimensional Array in Reverse Order
        static void PrintReverseArray(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        } 
        #endregion

        public static void Main()
        {
            #region Question 1 Value type parameters

            #region 1-Passing By Value
            //int n1 = 10, n2 = 5;
            //Swap(n1, n2);
            //Console.WriteLine($"n1 = {n1}");
            //Console.WriteLine($"n2 = {n2}");

            #endregion

            #region 2-Passing By Reference
            //int x = 10, y = 5;
            //SwapRef(ref x,ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion

            #endregion

            #region Question 2 Reference type parameters


            #region 1-Passing By Value

            //int[] numbers = { 0, 1, 2, 3, 4 };
            //Arr1(numbers);
            //Console.WriteLine(numbers[0]);

            #endregion

            #region 2-Passing By Reference
            //int[] numbers = { 0, 1, 2, 3, 4 };
            //Arr2(ref numbers);
            //Console.WriteLine(numbers[0]);

            #endregion

            #endregion

            #region Question 3



            //int A = 4, B = 5;

            //Sum_Sub(A, B, out int Sum, out int Sub);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Sub);

            #endregion

            #region Question 4
            //int n = 239475; // 2394.7

            //Console.WriteLine(SumOfDigit(n));

            //int result = SumOfDigit(n);
            //Console.WriteLine($"The sum of the digits of the number {n} is: {result}");

            #endregion

            #region Question 5

            //int n = 10;

            //Console.WriteLine(IsPrime(n));

            #endregion

            #region Question 6
            //int[] numbers = { 0, -5, 10, 50, 100, 5 };
            //int max = 0, min = 0;
            //minmaxarray(numbers, ref max, ref min);
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            #endregion

            #region Question 7

            //int fact = 0;
            //Console.WriteLine(factorial(fact));


            #endregion

            #region Question 8
            //Console.WriteLine("Enter a string: ");
            //string word = Console.ReadLine();

            //char letter;
            //int index;
            //string result;

            //Console.WriteLine("Enter Index : ");
            //index = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter letter : ");
            //letter = char.Parse(Console.ReadLine());

            //result = ChangeChar(word, index, letter);
            //Console.WriteLine($"New Word = {result}");

            #endregion

            #region Question 9

            //Console.Write("Enter the size of the identity matrix: ");
            //if (int.TryParse(Console.ReadLine(), out int n) )
            //{
            //    Console.WriteLine($"Identity Matrix of size {n}x{n}:");
            //    IdentityMatrix(n);
            //}

            #endregion

            #region Question 10  


            //int[] Numbers = { 4, 5, 6 };

            //int Result = SumArray(Numbers);   

            //Console.WriteLine(Result);



            #endregion

            #region Question 11

            #endregion

            #region Question 12

            // Console.Write("Enter the size of the array: ");
            // int size = int.Parse(Console.ReadLine());

            // int[] numbers = new int[size];

            // for (int i = 0; i < size; i++)
            // {
            //     Console.Write($"Enter element [{i + 1}]: ");
            //     numbers[i] = int.Parse(Console.ReadLine());
            // }

            //minmaxarray(numbers, out int max, out int min);

            // Console.WriteLine("\nMaximum element = " + max);
            // Console.WriteLine("Minimum element = " + min);

            #endregion

            #region Question 14

            //Console.Write("Enter the size of the array: ");
            //if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //{
            //    int[] arr = new int[n];
            //    Console.WriteLine($"Enter {n} elements for the array:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (!int.TryParse(Console.ReadLine(), out arr[i]))
            //        {
            //            Console.WriteLine("Invalid input. Please enter valid numbers.");
            //            return;
            //        }
            //    }

            //    int maxDistance = FindMaxDistance(arr);
            //    if (maxDistance == -1)
            //        Console.WriteLine("There are not enough elements to calculate the distance.");
            //    else
            //        Console.WriteLine($"The maximum distance between any two cells is: {maxDistance}");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid positive number for the array size.");
            //}

            #endregion

            #region Question 17

            //Console.Write("Enter the size of the array: ");
            //if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //{
            //    int[] arr = new int[n];
            //    Console.WriteLine($"Enter {n} elements for the array:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (!int.TryParse(Console.ReadLine(), out arr[i]))
            //        {
            //            Console.WriteLine("Invalid input. Please enter valid numbers.");
            //            return;
            //        }
            //    }

            //    Console.WriteLine("Array in reverse order:");
            //    PrintReverseArray(arr);
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid positive number for the array size.");
            //}
            #endregion
        }
    }

}