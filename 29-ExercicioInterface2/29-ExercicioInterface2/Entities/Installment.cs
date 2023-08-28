using System.Globalization;

namespace _29_ExercicioInterface2.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - R$ "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
