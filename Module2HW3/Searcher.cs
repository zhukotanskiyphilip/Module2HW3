namespace Module2HW3
{
    public static class Searcher
    {
        public static Sweets[] Search(this Gift gift, string name)
        {
            Sweets[] sweets = new Sweets[10];

            for (int i = 0; i < 10; i++)
            {
                if (gift.Sweets[i].Name == name)
                {
                    sweets[i] = gift.Sweets[i];
                }
            }

            return sweets;
        }

        public static Sweets[] Search(this Gift gift, float price)
        {
            Sweets[] sweets = new Sweets[10];

            for (int i = 0; i < 10; i++)
            {
                if (gift.Sweets[i].Price == price)
                {
                    sweets[i] = gift.Sweets[i];
                }
            }

            return sweets;
        }

        public static Sweets[] Search(this Gift gift, int weight)
        {
            Sweets[] sweets = new Sweets[10];

            for (int i = 0; i < 10; i++)
            {
                if (gift.Sweets[i].Weight == weight)
                {
                    sweets[i] = gift.Sweets[i];
                }
            }

            return sweets;
        }

        public static Sweets[] Search(this Gift gift, EnumProperties.EShape shape)
        {
            Sweets[] sweets = new Sweets[10];

            for (int i = 0; i < 10; i++)
            {
                if (gift.Sweets[i].Shape == shape)
                {
                    sweets[i] = gift.Sweets[i];
                }
            }

            return sweets;
        }

        public static Sweets[] Search(this Gift gift, EnumProperties.EConsistency consistency)
        {
            Sweets[] sweets = new Sweets[10];

            for (int i = 0; i < 10; i++)
            {
                if (gift.Sweets[i].Consistency == consistency)
                {
                    sweets[i] = gift.Sweets[i];
                }
            }

            return sweets;
        }

        public static Sweets[] Search(this Gift gift, EnumProperties.EColor color)
        {
            Sweets[] sweets = new Sweets[10];

            for (int i = 0; i < 10; i++)
            {
                if (gift.Sweets[i].Color == color)
                {
                    sweets[i] = gift.Sweets[i];
                }
            }

            return sweets;
        }

        public static Sweets[] Search(this Gift gift, Packaged.PackageType pType)
        {
            Sweets[] sweets = new Sweets[10];
            Packaged packaged;

            for (int i = 0; i < 10; i++)
            {
                if (gift.Sweets[i] is Packaged)
                {
                    packaged = (Packaged)gift.Sweets[i];

                    if (packaged.PType == pType)
                    {
                        sweets[i] = gift.Sweets[i];
                    }
                }
            }

            return sweets;
        }

        public static Sweets[] Search(this Gift gift, ChocolateBar.EDimensions dimensions)
        {
            Sweets[] sweets = new Sweets[10];
            ChocolateBar chocolateBar;

            for (int i = 0; i < 10; i++)
            {
                if (gift.Sweets[i] is ChocolateBar)
                {
                    chocolateBar = (ChocolateBar)gift.Sweets[i];
                    if (chocolateBar.Dimensions == dimensions)
                    {
                        sweets[i] = gift.Sweets[i];
                    }
                }
            }

            return sweets;
        }
    }
}
