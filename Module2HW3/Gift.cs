using Module2HW3.Candy;

namespace Module2HW3
{
    public class Gift : Product
    {
        public Gift()
        {
            Name = "Random Generated Gift";

            Sweets = new Sweets[10];

            Random rand = new Random();

            for (int i = 0; i < Sweets.Length; i++)
            {
                switch (rand.Next(1, 9))
                {
                    case 1:
                        AtomicFireball atomicFireball = new AtomicFireball();
                        Sweets[i] = atomicFireball;
                        break;
                    case 2:
                        Caramello caramello = new Caramello();
                        Sweets[i] = caramello;
                        break;
                    case 3:
                        GummyBear gummyBear = new GummyBear();
                        Sweets[i] = gummyBear;
                        break;
                    case 4:
                        Hersheys hersheys = new Hersheys();
                        Sweets[i] = hersheys;
                        break;
                    case 6:
                        LemonHead lemonHead = new LemonHead();
                        Sweets[i] = lemonHead;
                        break;
                    case 7:
                        Musketeers musketeers = new Musketeers();
                        Sweets[i] = musketeers;
                        break;
                    case 8:
                        Skittles skittles = new Skittles();
                        Sweets[i] = skittles;
                        break;
                    case 9:
                        SugarBabies sugarBabies = new SugarBabies();
                        Sweets[i] = sugarBabies;
                        break;
                }
            }

            foreach (var candy in Sweets)
            {
                Price += candy.Price;
                Weight += candy.Weight;
            }
        }

        public Sweets[] Sweets { get; set; }
    }
}
