namespace Module2HW3.Candy
{
    public class Caramello : ChocolateBar
    {
        public Caramello()
        {
            Name = "Caramello";
            Price = 4f;
            Weight = 115;
            Shape = EShape.Rectangle;
            Consistency = EConsistency.Soft;
            Color = EColor.Brown;
            PType = PackageType.Paper_Wrapper;

            SetDimensions(EDimensions.Small);
        }
    }
}
