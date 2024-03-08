using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService

        //Interfaceler belli methot imzalarını barındırırlar
        //biribirine alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlarlar 
    {
        //Sonar Qube yazılım kalitesi ölçüyor
        public void ApplyForMask(Person person)
        {
            
        }

        public bool CheckPerson(Person person)
        {
            return true;
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}
