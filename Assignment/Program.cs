namespace Assignment
{
    internal class Program
    {
        //public static void swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void swap2(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        public static void sumandsubtract(int x, int y, out int sum, out int subtract)
        {
            sum = x + y;
            subtract = x - y;
        }
        public static int digitsum(int x)
        {
            int sum = 0;
            while(x > 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }
        public static bool isprime(int x)
        {
            if (x < 2) return false;
            for(int i = 2; i < Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        public static void minmax(int[] arr, ref int min, ref int max)
        {
            min = max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min < arr[i]) min = arr[i];
                if (max < arr[i]) max = arr[i];
            }
        }
        public static int fact(int x)
        {
            if (x < 1) return 1;
            int fact = 1;
            for (int i = 1; i <= x; ++i)
            {
                fact *= x;
            }
            return fact;
        }
        public static string changechar(char x, int pos, string s)
        {
            char[] chars = s.ToCharArray();
            chars[pos] = x;
            return new string(chars);
        } 
        static void Main(string[] args)
        {
            #region Question1
            int x1, y1, x2, y2, x3, y3, slope1, slope2, slope3;
            Console.WriteLine("Enter the points values: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            slope1 = (y2 - y1) * (x2 - x1);
            slope2 = (y3 - y1) * (x3 - x1);
            slope3 = (y3 - y2) * (x3 - x2);
            if (slope1 == slope2 && slope3 == slope1) Console.WriteLine("The point lie on the same line");
            else Console.WriteLine("The points are't on the same line");
            #endregion

            #region Question2
            int Q2time = Convert.ToInt32(Console.ReadLine());
            if (Q2time >= 2 && Q2time <= 3) Console.WriteLine("Highly efficient");
            else if (Q2time >= 3 && Q2time <= 4) Console.WriteLine("Increase your speed");
            else if (Q2time >= 4 && Q2time <= 5) Console.WriteLine("Provided with training");
            else Console.WriteLine("Leave the company");
            #endregion

            #region Question3
            int Q3n = Convert.ToInt32(Console.ReadLine());
            int[,] Q3Martix = new int[Q3n, Q3n];
            for (int i = 0; i < Q3n; i++)
            {
                Q3Martix[i, i] = 1;
            }
            Console.WriteLine($"The identity matrix {Q3n} * {Q3n} size = ");
            for (int i = 0; i < Q3n; i++)
            {
                for (int j = 0; j < Q3n; j++)
                {
                    Console.WriteLine($"{Q3Martix[i, j]} ");
                }
            }
            #endregion

            #region Question20
            int Q20x = Convert.ToInt32(Console.ReadLine()), Q20sum = 0;
            int[] Q20arr = new int[Q20x];
            for (int i = 0; i < Q20x; i++)
            {
                Q20arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Q20x; i++)
            {
                Q20sum += Q20arr[i];
            }
            Console.WriteLine($"The sum of the array = {Q20sum}");
            #endregion

            #region Question21
            int Q21x;
            Q21x = Convert.ToInt32(Console.ReadLine());
            int[] Q21arr = new int[Q21x];
            int[] Q21ar = new int[Q21x];
            for (int i = 0; i < Q21x; i++)
            {
                Q21arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Q21x; i++)
            {
                Q21ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(Q21arr);
            Array.Sort(Q21ar);
            int[] Q21Merged = new int[Q21x * 2];
            int Q21i = 0, Q21j = 0;
            while (Q21i < Q21x && Q21j < Q21x)
            {
                if (Q21arr[Q21i] < Q21ar[Q21j])
                {
                    Q21Merged[Q21i] = Q21arr[Q21i];
                    Q21i++;
                }
                else if (Q21arr[Q21i] > Q21ar[Q21j])
                {
                    Q21Merged[Q21j] = Q21ar[Q21j];
                    Q21j++;
                }
                Q21Merged[Q21i] = Q21arr[Q21i];
                Q21i++;
                Q21Merged[Q21j] = Q21ar[Q21j];
                Q21j++;
            }
            Console.WriteLine("The merged array = ");
            for (int i = 0; i < Q21x * 2; i++)
            {
                Console.WriteLine(Q21Merged[i]);
            }
            #endregion

            #region Question22
            Console.WriteLine("Enter the size of array");
            int Q22x = Convert.ToInt32(Console.ReadLine());
            int[] Q22arr = new int[Q22x];
            int[] Q22freq = new int[Q22x];
            for (int i = 0; i < Q22x; i++) 
            {
                Q22arr[i] = Convert.ToInt32(Console.ReadLine());
                Q22freq[i] = -1;
            }
            for (int i = 0; i < Q22x; i++)
            {
                int cnt = 0;
                for (int j = 0; j < Q22x; ++j)
                {
                    if (Q22arr[i] == Q22arr[j]) cnt++;
                }
                Q22freq[i] = cnt;
            }
         
            Console.WriteLine("The frequency of each number = ");
            for (int i = 0; i < Q22x; i++)
            {
                Console.WriteLine(Q22freq[i]);
            }

            #endregion

            #region Question23
            int Q23x = Convert.ToInt32(Console.ReadLine());
            int[] Q23arr = new int[Q23x];
            for (int i = 0; i < Q23x; i++)
            {
                Q23arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(Q23arr);
            Console.WriteLine($"The maximum number of the array = {Q23arr[Q23x - 1]}, and the minimum = {Q23arr[0]}");
            #endregion

            #region Question24
            int Q24x = Convert.ToInt32(Console.ReadLine());
            int[] Q24arr = new int[Q24x];
            for (int i = 0;i < Q24x; i++)
            {
                Q24arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort (Q24arr);
            Console.WriteLine($"The second maximum number = {Q24arr[Q24x-2]}");
            #endregion

            #region Question25

            #endregion

            #region Question26
            string Q26s = Console.ReadLine();
            string[] rev = Q26s.Split(' ');
            Array.Reverse(rev);
            for(int i = 0;i<rev.Length;i++)
            {
                Console.Write($"{rev[i]} ");
            }
            #endregion

            #region Question27
            int Q27x, Q27y;
            Q27x = Convert.ToInt32(Console.ReadLine());
            Q27y = Convert.ToInt32(Console.ReadLine());
            int[,] Q27arr = new int[Q27x,Q27y];
            int[,] Q27ar = new int[Q27x,Q27y];
            for(int i = 0; i < Q27x; i++)
            {
                for(int j = 0; j < Q27y; j++)
                {
                    Q27arr[i,j] = Convert.ToInt32(Console.ReadLine());
                    Q27ar[i, j] = Q27arr[i, j];
                }
            }
            Console.WriteLine("The second array after copying = ");
            for (int i = 0; i < Q27x; ++i)
            {
                for (int j = 0;j < Q27y; j++)
                {
                    Console.Write(Q27ar[i,j]);
                }
                Console.WriteLine();
            }
            #endregion

            #region Question28
            int Q28x = Convert.ToInt32(Console.ReadLine());
            int[] Q28arr = new int[Q28x];
            for(int i = 0;i < Q28x; ++i)
            {
                Q28arr[i] = Convert.ToInt32(Console.Read());
            }
            for(int i = Q28x - 1; i >= 0; --i)
            {
                Console.Write($"{Q28arr[i]} ");
            }
            #endregion

            #region Functions
            #region Question1
            //int x = 3, y = 5;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //swap(x, y);
            //Console.WriteLine(x);
            //Console.WriteLine(y); // swap will not actually happen because of (passing by value)
            //swap2(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y); // swap will happen because of (passing by reference)
            // passing by value make a copy of the original data. the changes happened to the parameters in the method not on the variables outside the method
            // passing by reference operates on the original value given (reference) not make a copy and operates with it

            #endregion

            #region Question2

            #endregion

            #region Question3
            int FQ3x, FQ3y, FQ3sum, FQ3Sub;
            FQ3x = Convert.ToInt32(Console.ReadLine());
            FQ3y = Convert.ToInt32(Console.ReadLine());
            sumandsubtract(FQ3x, FQ3y, out FQ3sum, out FQ3Sub);
            Console.WriteLine($"The sum of two numbers = {FQ3sum}, and subtract = {FQ3Sub}");
            #endregion

            #region Question4
            Console.Write("Enter a number");
            int FQ4x = Convert.ToInt32(Console.ReadLine());
            int FQ4sum = digitsum(FQ4x);
            Console.WriteLine($"The sum of the digits of the number {FQ4x} is: {FQ4sum}");
            #endregion

            #region Question5
            int FQ5x = Convert.ToInt32(Console.ReadLine());
            if (isprime(FQ5x)) Console.WriteLine("The number is prime");
            else Console.WriteLine("The number is not prime");
            #endregion

            #region Question6
            int FQ6x = Convert.ToInt32(Console.ReadLine());
            int FQ6min = 0, FQ6max = 0;
            int[] FQ6arr = new int[FQ6x];
            for(int i = 0; i < FQ6arr.Length; ++i)
            {
                FQ6arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            minmax(FQ6arr,ref FQ6min,ref FQ6max);
            Console.WriteLine($"The minimum number in the array = {FQ6min}, and the maximum = {FQ6max}");
            #endregion

            #region Question7
            int FQ7x = Convert.ToInt32(Console.ReadLine());
            int FQ7r = fact(FQ7x);
            Console.WriteLine($"The factorial of the number = {FQ7r}");
            #endregion

            #region Question8
            string s = Console.ReadLine();
            int pos = Convert.ToInt32(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            string ss = changechar(c, pos, s);
            Console.WriteLine($"The string after changing the char: {ss}");
            #endregion
            #endregion
        }
    }
}
