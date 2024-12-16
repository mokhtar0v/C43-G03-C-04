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
        }
    }
}
