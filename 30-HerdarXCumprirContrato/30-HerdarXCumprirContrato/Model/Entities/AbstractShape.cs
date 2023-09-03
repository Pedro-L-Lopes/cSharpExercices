using _30_HerdarXCumprirContrato.Model.Enums;

namespace _30_HerdarXCumprirContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
