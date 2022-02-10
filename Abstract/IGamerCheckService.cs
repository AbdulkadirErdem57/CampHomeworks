using CampHomeworks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampHomeworks.Abstract
{
    interface IGamerCheckService
    {
        bool GamerCheck(Gamer gamer);
    }
}
