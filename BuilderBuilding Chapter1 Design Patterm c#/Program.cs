namespace BuilderBuilding_Chapter1_Design_Patterm_c_;

    internal class Program
    {
        static void Main(string[] args)
        {
        var pb = new PersonBuilder();
        Person person = pb.Live.At("ss").In("sdsd");
        Console.WriteLine(person._Address.Location);
        Person person2 = new Person();
        Person p2 = new PersonBuilder()
            .Live.At("ss").In("sdsd");
        Person p3 = new Person(); 
    Person ab = new AddressBuilder(p3); // Here I make an Casting By implicit casting form the parent
        Console.WriteLine(ab);
    }
    }

