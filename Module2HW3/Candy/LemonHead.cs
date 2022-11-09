namespace Module2HW3.Candy
{
    public class LemonHead : Packaged.Packaged
    {
        public LemonHead()
        {
            Name = "Lemon Head";
            Price = 39.99f;
            Weight = 0.15f;
            Shape = EShape.Oval;
            Consistency = EConsistency.Hard;
            Color = EColor.Yellow;
            PType = PackageType.Paper_Wrapper;
        }
    }
}
