namespace Packaged
{
    public class Packaged : Sweets.Sweets
    {
        protected enum PackageType
        {
            Boxed,
            Plastic_Wrapper,
            Paper_Wrapper
        }

        protected PackageType PType { get; set; }
    }
}
