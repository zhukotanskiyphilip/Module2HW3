namespace Module2HW3.Candy
{
    internal class AtomicFireball : Packaged.Packaged
    {
        public AtomicFireball()
        {
            Name = "Atomic Fireball";
            Price = 10.99f;
            Weight = 0.05f;
            Shape = EShape.Sphere;
            Consistency = EConsistency.Soft;
            Color = EColor.Red;
            PType = PackageType.Plastic_Wrapper;
        }
    }
}
