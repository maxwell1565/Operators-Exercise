namespace OperatorExercise
{
    public class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //--------------exercise 1------------
            int a = 17;
            int b = 4;

            var sum = a + b;
            var multiply = a * b;
            var subtract = a - b;
            var divide = a / b;
            var modulus = a % b;

            //2 more division variables

            int quotent = a / b;
            int remainder = a % b;

            Console.WriteLine($"Answers to the operations: {sum}; {multiply}; {subtract}; {divide}; {modulus};");
            Console.WriteLine($"{a} divided by {b} is {quotent} with a remainder of {remainder}.");

            //-------------exercise 2-------------

            Console.WriteLine("What is the radius of your circle?");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

        }

        public static double AreaOfCircle(double radius)
        {

            var area = Math.PI * Math.Pow(radius, 2);

            return area;

        }
    }
}
