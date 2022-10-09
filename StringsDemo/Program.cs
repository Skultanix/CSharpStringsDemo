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

            //Example showcasing standard string formatting vs. verbatim strings
            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            var theCoolerText = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder1\folder4";

            Console.WriteLine(theCoolerText);
        }
    }
}