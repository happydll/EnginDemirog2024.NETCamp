using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PharmancyManager : IAppliPharmancyService
    {
        public List<Pharmancy> Getlist()
        {
            return null;
        }

        public bool CheckPharmancy(Pharmancy pharmancy)
        {
            //eczane kontrolü yapan service
            return true;
        }
    }
}
