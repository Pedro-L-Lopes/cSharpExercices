using System.Globalization;

namespace _30_HerdarXCumprirContrato.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", área = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
