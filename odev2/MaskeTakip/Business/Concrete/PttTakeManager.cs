using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttTakeManager : IDeliveryService
    {
        public void TakeMask(Pharmancy pharmancy )
        {
            Console.WriteLine("Maske " + pharmancy.PharmancyName + "'nden teslim alındı");
        }
    }
}
