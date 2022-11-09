namespace Sweets
{
    public abstract class Sweets : EnumProperties.EnumProperties
    {
        protected EShape Shape { get; set; }
        protected EConsistency Consistency { get; set; }
        protected EColor Color { get; set; }
        protected float Weight { get; set; }
    }
}
