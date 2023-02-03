
namespace StatiExtensionEnum
{

    public class Program
    {
        static void Main(string[] args)
        {


            User user1 = new User("Fatima", "Karimova", RegistrationMonth.September, "2023FEE");
            Console.WriteLine(user1.GetDetails());

            User user2 = new User("Azer", "Karimov", RegistrationMonth.June, "222GGGG");
            Console.WriteLine(user2.GetDetails());

            User user3 = new User("Amiqo", "Karimov", RegistrationMonth.July, "555FFFF");
            Console.WriteLine(user3.GetDetails());
            User user4 = new User("Kenan", "Tapdiqli", RegistrationMonth.September, "555555G");
            Console.WriteLine(user4.GetDetails());

            User user5 = new User("Aynur", "Karimova", RegistrationMonth.February, "55555555555555");
            Console.WriteLine(user5.GetDetails());
             


        }
    }
}
