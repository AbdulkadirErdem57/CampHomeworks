using CampHomeworks.Abstract;
using CampHomeworks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampHomeworks.Concture
{
    class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.GamerCheck(gamer))
            {
                Console.WriteLine("Gamer Added",gamer.FirstName," ",gamer.LastName);
            }
            else
                Console.WriteLine("Could not add gamer");
        }

        public void Delete(Gamer gamer)
        {
            if (_gamerCheckService.GamerCheck(gamer))
            {
                Console.WriteLine("Gamer Deleted", gamer.FirstName, " ", gamer.LastName);
            }
            else
                Console.WriteLine("Could not delete gamer");
        }

        public void Uptade(Gamer gamer)
        {
            if (_gamerCheckService.GamerCheck(gamer))
            {
                Console.WriteLine("Gamer updated", gamer.FirstName, " ", gamer.LastName);
            }
            else
                Console.WriteLine("Could not update gamer");
        }
    }
}
