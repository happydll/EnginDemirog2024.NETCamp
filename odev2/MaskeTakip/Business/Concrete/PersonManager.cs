using Business.Abstract;
using Entities.Concrete;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //çıplak class kalmasın
    public class PersonManager : IApplicantService
    {
        //encapsulation
        public void ApplyForMask(Person person)
        {
           
        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person) 
        {
            //mernis kontolü

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.Firstname, person.Lastname, person.DateOfBirth)))
                .Result.Body.TCKimlikNoDogrulaResult;
         }
    }
}
