using CampHomeworks.Entities;
using System;
using CampHomeworks.Concture;
using CampHomeworks.Adapters;

namespace CampHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { Id = 1, FirstName = "Abdulkadir", LastName = "Erdem", NationalityId =1234567892, YearsOfBirth = 2000 };

            

            Game game1 = new Game { Id = 1, Name = "Last of us", Price = 36.5 };


            Campaing campaign1 = new Campaing() { Id = 1,  Name = "Yaz İndirimleri" };
            Campaing campaign2 = new Campaing { Id = 2, Name = "Kış İndirimleri" };



            GamerManager gamerManager = new GamerManager(new MernisService());
            gamerManager.Add(gamer1);
            SalesManager salesManager = new SalesManager();


            salesManager.Sales(game1,gamer1,campaign1);
        }
    }
}
