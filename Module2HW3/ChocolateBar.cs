namespace ChocolateBar
{
    public class ChocolateBar : Packaged.Packaged
    {
        protected ChocolateBar(EDimensions dimensions)
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

        protected enum EDimensions
        {
            Small,
            Medium,
            Large
        }

        protected EDimensions Dimensions { get; set; }
        protected int Width { get; set; }
        protected int Length { get; set; }
    }
}
