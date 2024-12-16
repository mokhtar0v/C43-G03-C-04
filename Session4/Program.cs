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
        }
    }
}
