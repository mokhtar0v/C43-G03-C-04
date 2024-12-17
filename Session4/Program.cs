using System.Text;

namespace Session4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StringVsStringBuilder
            string name1;
            name1 = new string("GG");
            string name2 = "WP";
            name2 = name1;
            name1 = "omar";
            Console.WriteLine($"Name01 is: {name1}");
            Console.WriteLine($"Name02 is: {name2}");
            //string is an immutable type that can't change its value
            string message = "Hello";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());
            message += "Route"; //create new objet with different new identity 
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());
            sb.Append("Route");
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());
            #endregion

            #region One Dimension Array
            int[] numbers;
            //referring to default value of reference type null
            //declare for reference from type array of int
            // clr will allocate 4 bytes at stack for the reference because its integer
            // clr will allocate 0 bytes at heap
            numbers = new int[3]; //allocate 12 bytes at heap
            Console.WriteLine(numbers[0]);
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            int[] numbers2 = new int[3] { 1, 2, 3 } ;
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }
            #endregion

            #region Rectangular 2D Array
            int[,] marks = new int[3, 5] { { 43, 32, 21, 12, 32 }, { 43, 32, 21, 12, 32 }, { 43, 32, 21, 12, 32 } };
            // new-> allocate required bytes at heap (60 bytes)
            Console.WriteLine($"Size of array = {marks.Length}, Dimensions = {marks.Rank}");
            int[,] marks2 = new int[3, 5];
            for (int i =0; i<marks2.GetLength(0); i++)
            {
                Console.WriteLine($"Enter the marks of student {i+1}: ");
                for(int j = 0; j < marks2.GetLength(1); j++)
                {
                    marks2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0;i<marks2.GetLength(0); i++)
            {
                Console.WriteLine($"Marks of student {i + 1} is: ");
                for (int j = 0;j < marks2.GetLength(1); j++)
                {
                    Console.WriteLine(marks2[i,j]); // print each value in the 2D array
                }
            }
            #endregion

            #region Judjed Array
            int[][] judje = new int[3][];
            judje[0] = new int[] { 1, 2, 3 };
            judje[1] = new int[] { 4, 5 };
            judje[2] = new int[] { 5 };
            for (int i = 0; i < judje.Length; i++)
            {
                for (int j = 0; j < judje[i].Length; ++j)
                {
                    Console.WriteLine(judje[i][j]);
                }
            }
            #endregion

            #region Array Methods
            int[] arr = { 5, 2, 1, 9, 7, 4 };
            int[] arr01 = { 1, 2, 3 };
            int[] arr02 = new int[5];

            //Class Member Methods
            Array.Sort(arr); // Sorting the array in an ascending order
            Array.Copy(arr01, arr02, 2);
            #endregion
        }
    }
}
