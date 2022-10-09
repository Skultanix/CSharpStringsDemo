namespace StringsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            var firstName = "Caleb";
            var lastName = "Ricks";


            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);


        }
    }
}