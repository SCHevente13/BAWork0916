namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Dog doggo1 = new Dog("Bodri", "Labrador", 5);
            Dog doggo2 = new Dog("Morzsi", "Beagle", 3);
            Phone phone1 = new Phone("Samsung", "Galaxy S24");
            Phone phone2 = new Phone("Apple", "iPhone 16", 350000);
            Player player1 = new Player("Steve");
            Player player2 = new Player("Alex", 5, 1200);
            Car car1 = new Car("Toyota", "Corolla", 2018);
            Car car2 = new Car("BMW", "320i", 2021);

        }
    }
}
