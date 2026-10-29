namespace davaleba_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();

            user1.Name = "shota";
            user1.LastName = "mexanikosi";
            user1.Age = 22;
            user1.Email = "shota@gmail.com";
            user1.Password = "12345678";
            user1.PhoneNumber = "599123456";
            user1.Salary = 1500;
            user1.UserName = "shota";
            user1.Country = "Georgia";
            user1.Score = 90;

            Console.WriteLine(user1.Name);
            Console.WriteLine(user1.LastName);
            Console.WriteLine(user1.Age);
            Console.WriteLine(user1.Email);
            Console.WriteLine(user1.PhoneNumber);
            Console.WriteLine(user1.Salary);
            Console.WriteLine(user1.UserName);
            Console.WriteLine(user1.Country);
            Console.WriteLine(user1.Score);
        }
    }
}
