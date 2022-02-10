using CampHomeworks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampHomeworks.Abstract
{
    interface ISalesService
    {
        void Sales(Game game, Gamer gamer,Campaing campaing);
    }
}
