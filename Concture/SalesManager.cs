using CampHomeworks.Abstract;
using CampHomeworks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampHomeworks.Concture
{
     class SalesManager : ISalesService
    {
        public void Sales(Game game, Gamer gamer, Campaing campaing)
        {
            Console.WriteLine(game.Name+"The game has been sold.\nDetail:\nThe person Who bought the game:"+gamer.FirstName+" "+gamer.LastName
                +"\ncampaing name:"+campaing.Name+"\nprice of the game:"+game.Price);
        }

        
    }
}
