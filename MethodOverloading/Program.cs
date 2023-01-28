using System.Transactions;

namespace MethodOverloading
{
    public class Methods
    {
        static void Main(string[] args)
        {
            
            var answer = Methods.Add(2, 2, true);
            Console.WriteLine(answer);
                       
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;
            if (isTrue && sum > 1)
            {
                return $"{sum} dollars";
            }

            else if (isTrue && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
    }

}
