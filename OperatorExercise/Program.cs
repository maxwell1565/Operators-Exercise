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
            Console.WriteLine($"17 divided by 4 is {quotent} with a remainder of {remainder}.");

        }
    }
}
