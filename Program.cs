//Assignment Session 05 Functions

namespace Assignment_Session_05_Solution
{
    internal class Program
    {

        static void Main(string[] args)
        {


            #region Q1
            //1. Explain the difference between passing(Value type parameters) by value and by reference then
            //   write a suitable c# example.

            //void SwapByRef(ref int x, ref int y)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //}

            //void SwapByValue(int x, int y)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //}

            ////passing by value ==> the parameter takes a coby of data.
            //int x = 1, y = 2;
            //SwapByValue(x, y);
            ////x = 1 , y = 2

            ////passing by reference ==> the parameter takes the address of the data.
            //int x = 1 , y = 2 ;
            //SwapByValue(ref x,ref y);
            ////x = 2 , y = 1

            #endregion

            #region Q2
            //2. Explain the difference between passing(Reference type parameters) by value and by reference then
            //   write a suitable c# example.

            //void DeclareNewArrayByRef(ref int[] arr)
            //{
            //    arr = new int[arr.Length];
            //}

            //void DeclareNewArrayByValue(int[] arr) 
            //{
            //    arr = new int[arr.Length];
            //}

            //passing by value ==> the parameter takes a coby of the address.
            //int[] myArray = { 1, 2, 3 };
            //DeclareNewArrayByValue(myArray);
            ////myArray still = { 1, 2, 3 }

            ////passing by reference ==> the parameter takes the address of the allocated variable.
            //int[] myArray = { 1, 2, 3 };
            //DeclareNewArrayByRef(ref myArray);
            ////myArray = { 0 ,0 , 0 }

            #endregion

            #region Q3
            //3. Write a c# Function that accept 4 parameters from user and return result of summation and
            //   subtracting of two numbers.

            //void CalculateSumAndSubOfTwoNums(int n1, int n2, out int sum, out int sub) 
            //{
            //    sum = n1 + n2;
            //    sub = n1 - n2;
            //}

            #endregion

            #region Q4
            //4. Write a program in C# Sharp to create a function to calculate the sum of the individual digits
            //   of a given number.
            //    Output should be like
            //    Enter a number: 25
            //    The sum of the digits of the number 25 is: 7

            //long SumOfTheIndividualDigits(int number)
            //{
            //    long sum = 0;
            //    while (number != 0) 
            //    {
            //        sum += number % 10;
            //        number /= 10;
            //    }
            //    return sum;
            //}

            //int number = 25;
            //long sumOfDigits = SumOfTheIndividualDigits(number);
            //Console.WriteLine(number);

            #endregion

            #region Q5
            //5. Create a function named "IsPrime", which receives an integer number and retuns true
            //   if it is prime, or false if it is not:

            //bool IsPrime(int number)
            //{
            //    int numberSqrt = (int)Math.Sqrt(number);
            //    if (numberSqrt*numberSqrt == number) return false;

            //    for (int i = 2; i < numberSqrt; i++)
            //    {
            //        if (number % i == 0) return false;
            //    }

            //    return true;
            //}
            //Console.WriteLine(IsPrime(55));
            //Console.WriteLine(IsPrime(5));

            #endregion

            #region Q6
            //6. Create a function named MinMaxArray, to return the minimum and maximum values stored in an array,
            //   using reference parameters

            //void MinMaxArray(int[] arr, out int? min, out int? max)
            //{
            //    min = null;
            //    max = null;
            //    if (arr.Length > 1)
            //    {
            //        min = arr[0];
            //        max = arr[1];
            //        for (int i = 0; i < arr.Length; i++)
            //        {
            //            if (arr[i] < min) min = arr[i];
            //            if (arr[i] > max) max = arr[i];
            //        }
            //    }
            //}


            #endregion

            #region Q7
            //7. Create an iterative(non-recursive) function to calculate the factorial of the number
            //   specified as parameter

            //long FactorialOf(int number)
            //{
            //    long result = 1;
            //    for (int i = 2; i <= number; i++)
            //    {
            //        result *= i;
            //    }
            //    return result;
            //}
            #endregion

            #region Q8
            //8. Create a function named "ChangeChar" to modify a letter in a certain position(0 based)
            //   of a string, replacing it with a different letter

            //void ChangeChar(ref string str, char replacementChar, int position)// ref ==> for protective code
            //{
            //    if (position >= 0 && position < str.Length)
            //        return;

                /////str[position]=replacmentChar;

                //char[] charArray = str.ToCharArray();

                //charArray[position] = replacementChar;

                //str = new string(charArray);
            //}
            #endregion


        }
    }
}
