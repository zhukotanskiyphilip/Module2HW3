namespace Module2HW3.Candy
{
    public class Hersheys : ChocolateBar
    {
        public Hersheys()
        {
            Name = "Hersheys";
            Price = 1.99f;
            Weight = 140;
            Shape = EShape.Rectangle;
            Consistency = EConsistency.Soft;
            Color = EColor.Brown;
            PType = PackageType.Paper_Wrapper;

            SetDimensions(EDimensions.Medium);
        }
    }
}
