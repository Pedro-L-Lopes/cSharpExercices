using Course.Services;

namespace Course
{

    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 5;

            BinaryNumericOperation op = CalculationService.Max;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}