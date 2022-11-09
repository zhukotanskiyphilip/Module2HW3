namespace Module2HW3.Candy
{
    public class LemonHead : Packaged
    {
        public LemonHead()
        {
            Name = "Lemon Head";
            Price = 19.99f;
            Weight = 150;
            Shape = EShape.Oval;
            Consistency = EConsistency.Hard;
            Color = EColor.Yellow;
            PType = PackageType.Paper_Wrapper;
        }
    }
}
