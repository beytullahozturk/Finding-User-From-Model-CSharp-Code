using System;
using System.Collections.Generic;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Name = "Beytullah" });
            users.Add(new User() { Id = 2, Name = "Zübeyde" });
            users.Add(new User() { Id = 3, Name = "Ahmet" });
            users.Add(new User() { Id = 4, Name = "Zehra" });
            users.Add(new User() { Id = 5, Name = "İbrahim" });
            users.Add(new User() { Id = 6, Name = "Ali" });
            users.Add(new User() { Id = 7, Name = "Habibe" });
            users.Add(new User() { Id = 8, Name = "Emre" });
            users.Add(new User() { Id = 9, Name = "Egemen" });

            Random random = new Random();
            int rastgeleSayi = random.Next(1, users.Count);
            Console.WriteLine($"Rastgele Seçilen Üye: \n{users[rastgeleSayi].Id} - {users[rastgeleSayi].Name}");

        }
        class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
