using CampHomeworks.Abstract;
using CampHomeworks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampHomeworks.Concture
{
    class CampaingManager : ICamapingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Camapaing added",campaing.Name);
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Camapaing deleted", campaing.Name);
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Camapaing Updated", campaing.Name);
        }
    }
}
