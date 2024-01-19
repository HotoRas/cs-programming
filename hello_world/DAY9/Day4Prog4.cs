namespace csproject;
public class Day4_Program4
{
    static void Run()
    {
        Address address = new("B1-3029", "BBSR", "Odisha");
        Employee employee = new(1001, "Ramesh", address);
        employee.Display();
    }

    class Address
    {
        public string AddressLine, City, State;
        public Address(string addL, string city, string state)
        {
            AddressLine = addL;
            City = city;
            State = state;
        }
    }
    class Employee
    {
        public Address address;
        public int Id;
        public string Name;
        public Employee(
            int id, string name, Address addr
        )
        {
            Id = id;
            Name = name;
            address = addr;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {address.AddressLine}");
        }
    }
}