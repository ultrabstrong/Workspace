using Corely.Connections;
using Corely.Connections.Proxies;
using Corely.Data.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corely.LibPostalClient
{
    public static class LibPostalClient
    {
        public static LibPostalServiceResponse ParseAddress(string address)
        {
            HttpProxy proxy = new HttpProxy();
            proxy.Connect("https://<service-url>");
            HttpParameters parameters = new HttpParameters("address", address);
            string xmlResult = proxy.SendRequestForStringResult("/LibPostal/LibPostalService.svc/web/ParseAddress", Connections.HttpMethod.Get, null, null, parameters);
            LibPostalServiceResponse response = XmlSerializer.DeSerialize<LibPostalServiceResponse>(xmlResult);
            return response;
        }
    }
}
