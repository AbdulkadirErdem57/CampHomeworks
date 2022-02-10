using CampHomeworks.Abstract;
using CampHomeworks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampHomeworks.Concture
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game added",game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game deleted", game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated", game.Name);
        }
    }
}
