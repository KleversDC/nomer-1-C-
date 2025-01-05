using System;
using System.Data;

class Program
{
    //static void Main()
    //{
    //    int[] A = new int[5];
    //    Console.WriteLine("Enter 5 numbers for array A:");
    //    for (int i = 0; i < A.Length; i++)
    //        A[i] = int.Parse(Console.ReadLine());

    //    double[,] B = new double[3, 4];
    //    Random rand = new Random();
    //    for (int i = 0; i < 3; i++)
    //        for (int j = 0; j < 4; j++)
    //            B[i, j] = rand.NextDouble() * 100;

    //    Console.WriteLine("Array A:");
    //    for (int i = 0; i < A.Length; i++)
    //        Console.Write(A[i] + " ");
    //    Console.WriteLine("\nArray B:");
    //    for (int i = 0; i < 3; i++)
    //    {
    //        for (int j = 0; j < 4; j++)
    //            Console.Write($"{B[i, j]:F2} ");
    //        Console.WriteLine();
    //    }

    //    int maxA = A[0], minA = A[0], sumA = 0, productA = 1, evenSumA = 0;
    //    for (int i = 0; i < A.Length; i++)
    //    {
    //        if (A[i] > maxA) maxA = A[i];
    //        if (A[i] < minA) minA = A[i];
    //        sumA += A[i];
    //        productA *= A[i];
    //        if (A[i] % 2 == 0) evenSumA += A[i];
    //    }

    //    double maxB = B[0, 0], minB = B[0, 0], sumB = 0, productB = 1;
    //    double oddColSumB = 0;
    //    for (int i = 0; i < 3; i++)
    //    {
    //        for (int j = 0; j < 4; j++)
    //        {
    //            double value = B[i, j];
    //            if (value > maxB) maxB = value;
    //            if (value < minB) minB = value;
    //            sumB += value;
    //            productB *= value;
    //            if (j % 2 != 0) oddColSumB += value;
    //        }
    //    }

    //    double globalMax = Math.Max(maxA, maxB);
    //    double globalMin = Math.Min(minA, minB);
    //    double totalSum = sumA + sumB;
    //    double totalProduct = productA * productB;

    //    Console.WriteLine($"Max: {globalMax}, Min: {globalMin}, Total Sum: {totalSum:F2}, Total Product: {totalProduct:F2}");
    //    Console.WriteLine($"Sum of even elements in A: {evenSumA}, Sum of odd columns in B: {oddColSumB:F2}");
    //}
    //2
    //static void Main()
    //{
    //    int[,] arr = new int[5, 5];
    //    Random rand = new Random();
    //    for (int i = 0; i < 5; i++)
    //        for (int j = 0; j < 5; j++)
    //            arr[i, j] = rand.Next(-100, 101);

    //    int min = int.MaxValue, max = int.MinValue, minIndex = 0, maxIndex = 0;
    //    for (int i = 0; i < 25; i++)
    //    {
    //        int val = arr[i / 5, i % 5];
    //        if (val < min)
    //        {
    //            min = val;
    //            minIndex = i;
    //        }
    //        if (val > max)
    //        {
    //            max = val;
    //            maxIndex = i;
    //        }
    //    }

    //    int start = Math.Min(minIndex, maxIndex) + 1;
    //    int end = Math.Max(minIndex, maxIndex);
    //    int sum = 0;
    //    for (int i = start; i < end; i++)
    //        sum += arr[i / 5, i % 5];

    //    Console.WriteLine($"Sum of elements between {min} and {max}: {sum}");
    //}
    //3
    //static string Caesar(string text, int shift)
    //{
    //    shift %= 26;
    //    char Cipher(char c)
    //    {
    //        if (!char.IsLetter(c)) return c;
    //        char offset = char.IsUpper(c) ? 'A' : 'a';
    //        return (char)((c - offset + shift + 26) % 26 + offset);
    //    }

    //    string result = "";
    //    foreach (char c in text)
    //        result += Cipher(c);
    //    return result;
    //}

    //static void Main()
    //{
    //    Console.WriteLine("Enter text:");
    //    string text = Console.ReadLine();
    //    Console.WriteLine("Enter shift:");
    //    int shift = int.Parse(Console.ReadLine());
    //    string encrypted = Caesar(text, shift);
    //    string decrypted = Caesar(encrypted, -shift);
    //    Console.WriteLine($"Encrypted: {encrypted}");
    //    Console.WriteLine($"Decrypted: {decrypted}");
    //}
    //4
    //static void Main()
    //{
    //    int[,] m1 = { { 1, 2 }, { 3, 4 } };
    //    int[,] m2 = { { 5, 6 }, { 7, 8 } };

    //    MultiplyByNumber(m1, 2);
    //    AddMatrices(m1, m2);
    //    MultiplyMatrices(m1, m2);
    //}

    //static void MultiplyByNumber(int[,] matrix, int n)
    //{
    //    for (int i = 0; i < matrix.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < matrix.GetLength(1); j++)
    //            Console.Write(matrix[i, j] * n + " ");
    //        Console.WriteLine();
    //    }
    //}

    //static void AddMatrices(int[,] m1, int[,] m2)
    //{
    //    for (int i = 0; i < m1.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < m1.GetLength(1); j++)
    //            Console.Write(m1[i, j] + m2[i, j] + " ");
    //        Console.WriteLine();
    //    }
    //}

    //static void MultiplyMatrices(int[,] m1, int[,] m2)
    //{
    //    int[,] result = new int[m1.GetLength(0), m2.GetLength(1)];
    //    for (int i = 0; i < m1.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < m2.GetLength(1); j++)
    //        {
    //            for (int k = 0; k < m1.GetLength(1); k++)
    //                result[i, j] += m1[i, k] * m2[k, j];
    //            Console.Write(result[i, j] + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //5
    //static void Main()
    //{
    //    Console.WriteLine("Enter an expression):");
    //    string input = Console.ReadLine();

    //    int result = 0;
    //    int currentNumber = 0;
    //    char operation = '+';

    //    for (int i = 0; i <= input.Length; i++)
    //    {
    //        if (i < input.Length && char.IsDigit(input[i]))
    //        {
    //            currentNumber = currentNumber * 10 + (input[i] - '0');
    //        }
    //        else
    //        {
    //            if (operation == '+')
    //                result += currentNumber;
    //            else if (operation == '-')
    //                result -= currentNumber;

    //            if (i < input.Length)
    //                operation = input[i];

    //            currentNumber = 0;
    //        }
    //    }

    //    Console.WriteLine($"Result: {result}");
    //}
    //6
    //static void Main()
    //{
    //    Console.WriteLine("Enter text:");
    //    string text = Console.ReadLine();

    //    string result = "";
    //    bool capitalize = true;
    //    foreach (char c in text)
    //    {
    //        if (capitalize && char.IsLetter(c))
    //        {
    //            result += char.ToUpper(c);
    //            capitalize = false;
    //        }
    //        else
    //        {
    //            result += c;
    //        }

    //        if (c == '.' || c == '?' || c == '!')
    //            capitalize = true;
    //    }

    //    Console.WriteLine(result);
    //}
    //7
    //static void Main()
    //{
    //    Console.WriteLine("Enter text:");
    //    string text = Console.ReadLine();
    //    Console.WriteLine("Enter forbidden word:");
    //    string badWord = Console.ReadLine();

    //    string result = "";
    //    int count = 0;

    //    string[] words = text.Split(new char[] { ' ', '.', ',', '?', '!', ';' }, StringSplitOptions.RemoveEmptyEntries);
    //    for (int i = 0; i < words.Length; i++)
    //    {
    //        if (words[i].Equals(badWord, StringComparison.OrdinalIgnoreCase))
    //        {
    //            result += new string('*', badWord.Length) + " ";
    //            count++;
    //        }
    //        else
    //        {
    //            result += words[i] + " ";
    //        }
    //    }

    //    Console.WriteLine("Filtered text:");
    //    Console.WriteLine(result.Trim());
    //    Console.WriteLine($"Replacements: {count}");
    //}
    }
