namespace Funcionario_log
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;

        public double CalcularMetade()
        {
            double media = Salario / 2;
            return media;
        }
    }
}