using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MinistryOfHealthManager : IShipMaskService
    {
        private IAppliPharmancyService _appliPharmancyService;

        public MinistryOfHealthManager(IAppliPharmancyService appliPharmancyService)
        {
            _appliPharmancyService = appliPharmancyService;
        }

        public void ShipMask(Pharmancy pharmancy)
        {
            if (_appliPharmancyService.CheckPharmancy(pharmancy))
            {
                Console.WriteLine("Maskeler " + pharmancy.PharmancyName + "'ne gönderildi");
            }
            else
            {
                Console.WriteLine("Maskeler " + pharmancy.PharmancyName + "'ne gönderilmedi!");
            }
        }
    }
}
