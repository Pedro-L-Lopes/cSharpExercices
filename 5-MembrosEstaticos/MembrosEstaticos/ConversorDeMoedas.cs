namespace Course
{
    class ConversorDeMoedas
    {
        public static double ValorTotal(double cotacao, double quantidade)
        {
            double valorAPagar = cotacao * quantidade;

            return valorAPagar + (valorAPagar / 100) * 6;
        }
    }
}
