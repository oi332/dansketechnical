using System;
using System.Text;

namespace DanskeTechnicalTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter height of pyramid: ");

            var height = 0;

            try
            {
                height = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Input can only be a number. Try again.");
            }

            var pyramid = ProducePyramid(height);

            Console.WriteLine(pyramid);
        }

        public static string ProducePyramid(int height)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < height; i++)
            {
                for (var spaces = height - i; spaces >= 0; spaces--)
                {
                    sb.Append(" ");
                }

                for (var stars = 1; stars <= (i + 1); stars++)
                {
                    sb.Append("*");
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
