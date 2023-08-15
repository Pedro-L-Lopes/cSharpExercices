namespace _10_ModificadorDeParametros
{
    internal class Calculadora
    {
        public static int sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
