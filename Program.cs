namespace PW4_2
{
    internal class Program
    {
        class Box
        {
            public int Weight { get; set; }
            public string Desc { get; set; }

            public Box(int weight, string desc)
            {
                Weight = weight;
                Desc = desc;
            }

        }
        class DeliveryService
        {
            public int WeightLimit { get; set; }

            public DeliveryService(int weightLimit)
            {
                WeightLimit = weightLimit;
            }

            public void AcceptDelivery(Box box)
            {
                if (WeightLimit >= box.Weight)
                {
                    Console.WriteLine("Посылка отправлена!");
                }
                else
                {
                    Console.WriteLine("Вес превышен!");
                }
            }
        }
        static void Main(string[] args)
        {
            Box posilka = new Box(15, "Пиво разливное");
            DeliveryService BoxBerry = new DeliveryService(10);

            BoxBerry.AcceptDelivery(posilka);
        }
    }
}