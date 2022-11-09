namespace Module2HW3
{
    public class ChocolateBar : Packaged
    {
        public enum EDimensions
        {
            Small,
            Medium,
            Large
        }

        public EDimensions Dimensions { get; set; }
        protected int Width { get; set; }
        protected int Length { get; set; }

        protected void SetDimensions(EDimensions dimensions)
        {
            switch (dimensions)
            {
                case EDimensions.Small:
                    Width = 4;
                    Length = 10;
                    break;
                case EDimensions.Medium:
                    Width = 8;
                    Length = 15;
                    break;
                case EDimensions.Large:
                    Width = 12;
                    Length = 20;
                    break;
            }
        }
    }
}
