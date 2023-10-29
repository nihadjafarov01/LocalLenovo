namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        ClownFish clownFish = new ClownFish();
        Shark shark = new Shark();
        Ostrich ostrich = new Ostrich();
        Parrot parrot = new Parrot();

        Animal[] animals = new Animal[] {clownFish, shark, ostrich, parrot};

        foreach (var animal in animals)
        {
            if (animal is Ostrich)
            {

            }
        }
    }
}