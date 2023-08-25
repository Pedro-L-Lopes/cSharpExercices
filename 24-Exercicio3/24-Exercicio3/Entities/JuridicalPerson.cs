namespace _24_Exercicio3.Entities
{
    internal class JuridicalPerson : Taxpayer
    {
        public int NumberOfEmployees { get; set; }

        public JuridicalPerson(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
