using ConsoleGameBackEndExample.Abstract;
using ConsoleGameBackEndExample.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameBackEndExample.Adapter
{
    public class CustomerAdapterService : ICustomerCheckService
    {
        public bool CheckRealPerson(Customer customer)
        {
            KPSPublicSoapClient client =  new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return  client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.Tc),customer.FirstName,customer.LastName,customer.DateofBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
