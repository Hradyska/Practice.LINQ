using System.Linq;
namespace Practice.LINQ
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<User> phoneBook = new List<User>()
            {
                new User() { Name = "Lisa", PhoneNumber = "+38(098)3471267" },
                new User() { Name = "George", PhoneNumber = "+38(098)5472263" },
                new User() { Name = "Ivan", PhoneNumber = "+7(043)6473427" },
                new User() { Name = "Anna", PhoneNumber = "+38(066)8472393" },
                new User() { Name = "Jack", PhoneNumber = "+38(098)5472263" },
                new User() { Name = "Joe", PhoneNumber = "+38(050)5300260" }
            };
            foreach (User user in phoneBook)
            {
                Console.WriteLine(user.ToString());
            }

            var someUser = phoneBook.FirstOrDefault(x => x.PhoneNumber.Contains("+7"));
            if (someUser != null)
            {
                Console.WriteLine($"This is bad guy: {someUser}");
                phoneBook.Remove(someUser);
            }

            var j = phoneBook.OrderBy(x => x.Name).Where(x => x.Name.Contains("J")).ToList();
            if (j != null)
            {
                Console.WriteLine(Environment.NewLine + "These are the users you found: ");
                foreach (User user in j)
                {
                    Console.WriteLine(user.ToString());
                }
            }

            var value = phoneBook.Select((User x) => x.PhoneNumber.Contains("(098)")).ToList();
            for (int i = 0; i < value.Count; i++)
            {
                if (value[i])
                {
                    Console.WriteLine("This is Kyivstar: " + phoneBook[i].ToString());
                }
            }
        }
    }
}