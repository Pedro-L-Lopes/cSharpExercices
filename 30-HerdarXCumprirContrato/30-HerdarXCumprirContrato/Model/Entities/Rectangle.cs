using System.Globalization;

namespace _30_HerdarXCumprirContrato.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color = "
               + Color
               + ", Width = "
               + Width.ToString("F2", CultureInfo.InvariantCulture)
               + ", Height = "
               + Height.ToString("F2", CultureInfo.InvariantCulture)
               + ", área = "
               + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
