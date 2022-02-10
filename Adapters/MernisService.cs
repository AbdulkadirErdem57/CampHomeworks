using CampHomeworks.Abstract;
using CampHomeworks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;
using static MernisServiceReference.KPSPublicSoapClient;


namespace CampHomeworks.Adapters
{
    internal class MernisService : IGamerCheckService
    {
        public bool GamerCheck(Gamer gamer)
        {
            var mernisClient = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync
                ((gamer.NationalityId), gamer.FirstName, gamer.LastName, gamer.YearsOfBirth).GetAwaiter().GetResult();
              return tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
        }
    }
}
