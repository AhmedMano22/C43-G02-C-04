namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("enter number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine(i + 1);
            //}
            #endregion

            #region Q2
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(number * i + " ");
            //}
            #endregion

            #region Q3
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    int EvenNumber;
            //    if (i % 2 == 0 )
            //    {
            //        EvenNumber = i;
            //      Console.WriteLine(EvenNumber);
            //    }
            //}

            #endregion

            #region Q4
            //Console.Write("Enter the number1: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the number2: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int result = (int)Math.Pow(number1, number2);
            //Console.WriteLine("Result: " + result);
            #endregion

            #region Q5
            //Console.WriteLine("Enter marks for five subjects: ");
            //int[] marks = new int[5];
            //int total = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //    total += marks[i];
            //}
            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;
            //Console.WriteLine($"Total: {total}, Average: {average}, Percentage: {percentage}%");
            #endregion

            #region Q6
            //Console.Write("Enter a string: ");
            //string? input = Console.ReadLine() ;
            //char[] reversed = input.ToCharArray();
            //Array.Reverse(reversed);
            //Console.WriteLine("Reversed: " + new string(reversed));
            #endregion

            #region Q7
            //Console.Write("Enter an integer: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int reversed = 0;
            //while (num != 0)
            //{
            //    reversed = reversed * 10 + num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine("Reversed integer: " + reversed);
            #endregion

            #region Q9
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //string binary = Convert.ToString(number, 2);
            //Console.WriteLine("Binary of " + number + " is " + binary);
            #endregion

            #region Q10
            //Console.WriteLine("Enter coordinates of three points:");
            //Console.Write("Enter x1, y1: ");
            //string[] point1 = Console.ReadLine().Split(',');
            //Console.Write("Enter x2, y2: ");
            //string[] point2 = Console.ReadLine().Split(',');
            //Console.Write("Enter x3, y3: ");
            //string[] point3 = Console.ReadLine().Split(',');

            //int x1 = int.Parse(point1[0]), y1 = int.Parse(point1[1]);
            //int x2 = int.Parse(point2[0]), y2 = int.Parse(point2[1]);
            //int x3 = int.Parse(point3[0]), y3 = int.Parse(point3[1]);


            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a straight line.");
            //}
            #endregion

            #region Q11
            //Console.Write("Enter the size of the matrix (n x n): ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region Q12
            //Console.Write("Enter array size: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //int sum = 0;

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += arr[i];
            //}

            //Console.WriteLine("Sum of elements: " + sum);
            #endregion
            #region Q13
            //int[] arr1 = { 1, 3, 5, 7 };
            //int[] arr2 = { 2, 4, 6, 8 };
            //int[] merged = new int[arr1.Length + arr2.Length];
            //int i = 0, j = 0, k = 0;

            //while (i < arr1.Length && j < arr2.Length)
            //{
            //    if (arr1[i] < arr2[j])
            //        merged[k++] = arr1[i++];
            //    else
            //        merged[k++] = arr2[j++];
            //}

            //while (i < arr1.Length)
            //    merged[k++] = arr1[i++];

            //while (j < arr2.Length)
            //    merged[k++] = arr2[j++];

            //Console.WriteLine("Merged array: ");
            //foreach (int num in merged)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion
            #region Q14
            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //var frequency = arr.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() });
            //foreach (var item in frequency)
            //{
            //    Console.WriteLine($"Element: {item.Value}, Frequency: {item.Count}");
            //}
            #endregion
            #region Q15
            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int max = arr[0], min = arr[0];
            //foreach (int num in arr)
            //{
            //    if (num > max) max = num;
            //    if (num < min) min = num;
            //}

            //Console.WriteLine($"Max: {max}, Min: {min}");
            #endregion
            #region Q16
            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int max = int.MinValue, secondMax = int.MinValue;
            //foreach (int num in arr)
            //{
            //    if (num > max)
            //    {
            //        secondMax = max;
            //        max = num;
            //    }
            //    else if (num > secondMax && num != max)
            //    {
            //        secondMax = num;
            //    }
            //}

            //Console.WriteLine($"Second largest element: {secondMax}");
            #endregion
            #region Q17

            #endregion
            #region Q18
            //Console.Write("Enter a sentence: ");
            //string? sentence = Console.ReadLine();
            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);
            //Console.WriteLine("Reversed: " + string.Join(" ", words));
            #endregion
            #region Q19
            //Console.Write("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[,] arr1 = new int[n, n];
            //int[,] arr2 = new int[n, n];

            //Console.WriteLine("Enter elements of the first array:");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Copy elements
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}

            //Console.WriteLine("Second array after copying:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q20
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(arr);
            Console.WriteLine("Reversed array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            #endregion








        }
    }
}
