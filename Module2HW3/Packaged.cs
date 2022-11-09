namespace Module2HW3
{
    public class Packaged : Sweets
    {
        public enum PackageType
        {
            Boxed,
            Plastic_Wrapper,
            Paper_Wrapper
        }

        public PackageType PType { get; set; }
    }
}
