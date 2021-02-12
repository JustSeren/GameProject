using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidatonManager());
            gamerManager.Add(new Gamer 
            { Id = 1, BirthYear = 1985, FirstName = "BEYZA", LastName = "BUYUKMANTICI", IdentityNumber = 123456 });
        }
    }
}
