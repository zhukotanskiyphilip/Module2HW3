namespace Module2HW3.Candy
{
    public class Musketeers : ChocolateBar
    {
        public Musketeers()
        {
            Name = "Musketeers";
            Price = 12f;
            Weight = 350;
            Shape = EShape.Rectangle;
            Consistency = EConsistency.Soft;
            Color = EColor.Brown;
            PType = PackageType.Paper_Wrapper;

            SetDimensions(EDimensions.Large);
        }
    }
}
