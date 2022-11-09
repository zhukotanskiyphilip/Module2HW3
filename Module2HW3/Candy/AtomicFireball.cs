namespace Module2HW3.Candy
{
    public class AtomicFireball : Packaged
    {
        public AtomicFireball()
        {
            Name = "Atomic Fireball";
            Price = 0.59f;
            Weight = 50;
            Shape = EShape.Sphere;
            Consistency = EConsistency.Soft;
            Color = EColor.Red;
            PType = PackageType.Plastic_Wrapper;
        }
    }
}
