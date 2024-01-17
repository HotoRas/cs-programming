namespace csproject;
class Day3_Program19
{
    static void CopyGenerator()
    {
        Console.WriteLine("using copy-generator");
        Person person1 = new("홍길동", 20);
        Person person2 = new(person1.name, person1.age);
        Console.WriteLine(person1.Print());
        Console.WriteLine(person2.Print());

        Person person3 = new(person1);
        Person person4 = new(person1);
        Person person5 = new(person1);
        Console.WriteLine(person3.Print());
        Console.WriteLine(person4.Print());
        Console.WriteLine(person5.Print());
    }
}
class Person
{
    public string name { get; set; }
    public int age { get; set; }
    string address { get; set; }
    string userID { get; set; }
    string userPassword { get; set; }
    string phoneNumber { get; set; }
    string gender { get; set; }

    public Person(string name, int age, string address = "", string userID = "0",
    string phoneNumber = "+821000000000", string gender = "")
    {
        this.name = name;
        this.age = age;
        this.address = address;
        this.userID = userID;
        this.userPassword = "";
        this.phoneNumber = phoneNumber;
        this.gender = gender;
    }

    public Person(Person person)
    {
        name = person.name;
        age = person.age;
        address = person.address;
        userID = person.userID;
        userPassword = person.userPassword;
        phoneNumber = person.phoneNumber;
        gender = person.gender;
    }

    public string Print() { return "이름: " + name + ", 나이: " + age; }
}