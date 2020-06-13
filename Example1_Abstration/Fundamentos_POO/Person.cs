namespace Fundamentos_POO
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string otherName, int otherAge)
        {
            this.Name = otherName;
            this.Age = otherAge;

        }

        public void SayHello(Person p)
        {
            System.Console.WriteLine("Hello new person, your name is "
                + "'{0}' and age '{1}' ", p.Name, p.Age);

        }

    }

}