namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new()
            {
                ["user"] = "maria",
                ["email"] = "maria@gmail.com",
                ["phone"] = "99771122",
                ["phone"] = "99771133"
            };
            Console.WriteLine(cookies["email"]);
            cookies.Remove("email");
            Console.WriteLine("Phone number: " + cookies["phone"]);
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }
            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES:");
            foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
