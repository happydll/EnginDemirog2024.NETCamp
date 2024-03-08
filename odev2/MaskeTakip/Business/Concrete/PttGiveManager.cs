using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttGiveManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttGiveManager(IApplicantService applicantService) //constructor newlendiğinde çalışır
        {
            _applicantService = applicantService;
        }
                
        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager();
            //bir iş sınıfı başka bir iş sınıfını kullanırken newliyorsa ileriye dönük değişiklik talebinde direnç gösterir.
            //yani newlediğimiz classa bağımlı hale geliriz

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.Firstname + " için makse verildi");
            }
            else
            {
                Console.WriteLine(person.Firstname +" için maske verilmedi");
            }

            
        }
    }
}
