using Business.Abstract;
using Entities.Concrete;
using MermisServiceReference;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest
            (new TCKimlikNoDogrulaRequestBody(123, "ilyas", "tuman", 1999))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
