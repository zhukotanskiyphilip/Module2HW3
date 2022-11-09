namespace Module2HW3.Candy
{
    public class SugarBabies : Packaged.Packaged
    {
        public SugarBabies()
        {
            Name = "Sugar Babies";
            Price = 1.99f;
            Weight = 0.05f;
            Shape = EShape.Oval;
            Consistency = EConsistency.Soft;
            Color = EColor.Brown;
            PType = PackageType.Boxed;
        }
    }
}
