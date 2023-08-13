namespace Course
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
        public double SalarioB;
        public double Imposto;
        public double Porcentagem;

        public double SalarioBruto()
        {
            return SalarioB = Salario - Imposto;
        }

        public double AumentoSalario()
        {
            return Salario += (Salario / 100) * Porcentagem;
        }


    }
}
