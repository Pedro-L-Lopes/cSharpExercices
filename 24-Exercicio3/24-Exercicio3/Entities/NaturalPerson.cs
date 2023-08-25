namespace _24_Exercicio3.Entities
{
    internal class NaturalPerson : Taxpayer
    {
        public double HealthSpending { get; set; }

        public NaturalPerson() { }

        public NaturalPerson(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000)
            {
                return AnnualIncome * 0.15 - HealthSpending * 0.5;
            }
            else
            {
                return AnnualIncome * 0.25 - HealthSpending * 0.5;
            }
        }
    }
}
