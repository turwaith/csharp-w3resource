/*
Write a C# Sharp program that takes userid and password as input (type string).
After 3 wrong attempts, user will be rejected
*/
using System;

namespace Exercice_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Takes userid and password as input (type string).
After 3 wrong attempts, user will be rejected");

            User userOne = new User("nicolas", "azerty");

            userOne.Check();
        }
    }

    class User
    {
        public string Id;
        public string Password;
        private int totalAttempt = 3;

        public User(string id, string password)
        {
            Id = id;
            Password = password;
        }

        public bool Check()
        {
            int count = 0;
            string id = String.Empty,
                   password = String.Empty;

            while (count++ < totalAttempt)
            {
                Console.Write("Enter your user id  : ");
                id = Console.ReadLine();
                Console.Write("Enter your password : ");
                password = Console.ReadLine();

                if(id == Id && password == Password)
                {
                    Console.WriteLine($"Welcome {Id}");
                    return true;
                }

                if(count != 0)                    
                    Console.WriteLine($"UserId and password don't match. {totalAttempt - count} attempt left");
            }

            Console.WriteLine("All attempts used. Try later");
            return false;
        }
    }
}
