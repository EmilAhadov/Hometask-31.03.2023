using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace gametask3
{
    internal class Program
    {
        //----------------------------------------------------------------------
        //Task1

        //    static void Main(string[] args)
        //    {
        //        Console.Write("Please enter the word: ");
        //        string word = Console.ReadLine();
        //        Console.WriteLine(Comparison(SplitString(word)));

        //    }
        //    static string[] SplitString(string word) 
        //    {
        //        string[] words = word.Split(' ');
        //        return words;
        //    }
        //    static string Comparison(string[] words)
        //    {
        //        string max = words[0];
        //        for(int i=0; i< words.Length; i++)
        //        {
        //            for(int j = i+1 ; j< words.Length; j++)
        //            {
        //                if (words[i].Length < words[j].Length)
        //                {
        //                    max = words[j];
        //                }
        //            }
        //        }
        //        return max;
        //    }

        //----------------------------------------------------------------------
        //Task2

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Sum(ArrayInput()));
        //}
        //static int[] ArrayInput()
        //{


        //    Console.Write("Please enter the array size: ");
        //    int size = Convert.ToInt32(Console.ReadLine());
        //    int[] numbers = new int[0];
        //    int[] digits = new int[0];
        //    for (int i = 0; i < size; i++)
        //    {
        //        Array.Resize(ref numbers, numbers.Length + 1);
        //        Console.Write("Please enter the array element: ");
        //        numbers[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    return numbers;
        //}
        //static int Sum(int[] numbers)
        //{
        //    int sum = 0;
        //    for(int i = 0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];
        //    }
        //    return sum;
        //}


        //----------------------------------------------------------------------
        //Task3

        //static void Main(string[] args)
        //{
        //    ToConvertUpperLetter(SplitStrings(Sentence()));
        //}
        //static string Sentence()
        //{
        //    Console.WriteLine("Please enter your sentence: ");
        //    string sentence = Console.ReadLine();
        //    return sentence;
        //}
        //static string[] SplitStrings(string sentence)
        //{
        //    string[] splitStrings = sentence.Split(' ');
        //    return splitStrings;
        //}
        //static void ToConvertUpperLetter(string[] stringArray)
        //{
        //    for(int i = 0; i < stringArray.Length; i++)
        //    {
        //        stringArray[i]= stringArray[i].Substring(0,1).ToUpper() + stringArray[i].Substring(1, stringArray[i].Length-1);
        //        Console.WriteLine(stringArray[i]);
        //    }

        //}


        //----------------------------------------------------------------------
        //Task4

        //static void Main(string[] args)
        //{
        //    string number = Number();
        //    if (Test(number))
        //    {
        //        Console.WriteLine(ConvertFloat(number));
        //    }
        //    else
        //    {
        //        Console.Write(ConvertInt(number));
        //    }

        //}
        //static string Number()
        //{
        //    Console.Write("Please enter a number: ");
        //    string number = Console.ReadLine();
        //    return number;
        //}
        //static bool Test(string number)
        //{
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        if (number[i] == ',')
        //        {
        //            return true;
        //        }

        //    }
        //    return false;

        //}
        //static int ConvertInt(string number)
        //{
        //    return Convert.ToInt32(number);
        //}
        //static float ConvertFloat(string number)
        //{
        //    return Convert.ToSingle(number);
        //}



        //----------------------------------------------------------------------
        //Task5

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(NumericalAverage(SplitNumbers(StringInput())));
        //}
        //static string StringInput()
        //{
        //    Console.Write("Please enter a number list: ");
        //    string numberList = Console.ReadLine();
        //    return numberList;
        //}
        //static string[] SplitNumbers(string numberList)
        //{
        //    string[] splitNumbers = numberList.Split(',');
        //    return splitNumbers;
        //}
        //static int NumericalAverage(string[] splitNumbers)
        //{
        //    int sum = default;
        //    int number = default;
        //    for(int i=0; i<splitNumbers.Length; i++)
        //    {
        //        number = int.Parse(splitNumbers[i]);
        //        sum += number;

        //    }
        //    return sum/splitNumbers.Length;

        //}










        //----------------------------------------------------------------------
        //Task6

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(AmountOfE(Strings()));
        //}
        //static string[] Strings()
        //{

        //    Console.Write("Please enter array size: ");
        //    int.TryParse(Console.ReadLine(), out int size);
        //    string[] strings = new string[size];
        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.Write($"Please enter {i + 1}.element of array: ");
        //        strings[i] = Console.ReadLine();
        //    }
        //    return strings;
        //}
        //static int AmountOfE(string[] strings)
        //{
        //    int count = default;
        //    for (int i = 0; i < strings.Length; i++)
        //    {
        //        for (int j = 0; j < strings[i].Length; j++)
        //        {
        //            string word = strings[i];
        //            if (word[j] == 'e')
        //            {
        //                count++;
        //                break;
        //            }
        //        }
        //    }
        //    return count;
        //}








        //----------------------------------------------------------------------
        //Task7

        //static void Main(string[] args)
        //{
        //    OddOrEven(NumberInput());
        //}
        //static int NumberInput()
        //{
        //    Console.WriteLine("Please enter a number: ");
        //    int number = int.Parse(Console.ReadLine());
        //    return number;
        //}
        //static void OddOrEven(int number)
        //{
        //    bool test = (number%2== 0) ? true:false;
        //    if (test)
        //    {
        //        Console.WriteLine("Number is Even");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Number is Odd");
        //    }

        //}







        //----------------------------------------------------------------------
        //Task8

        //static void Main(string[] args)
        //{
        //    AmounOfVowel(Sentence());
        //}
        //static string Sentence()
        //{
        //    Console.WriteLine("Please enter your sentence: ");
        //    string sentence = Console.ReadLine();
        //    return sentence;
        //}
        //static void AmounOfVowel(string sentence)
        //{
        //    int count = default;
        //    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        //    for(int i=0; i<sentence.Length; i++)
        //    {
        //        for(int j = 0;  j < vowels.Length; j++)
        //        {
        //            if (sentence[i] == vowels[j])
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    Console.WriteLine(count);
        //}

    }
}
