using BusinessLayer.Core;
using KelleyUtilities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentWeb.SiteConfiguration
{
    public class ApexPropertiesSiteDetails : ISiteDetails
    {
        public string CompanyName => "Apex Properties";

        public string CompanyShortName => "ApexProperties";

        public string EmailAddress => "rental.application406@gmail.com";

        public string PhoneNumber => "406-624-8074";

        public string Address => "PO Box 6584 Bozeman 59771";

        public MailSettings MailSettings => _mailSettings;

        public bool ShowTrash => false;

        public string PostOfficeAddress => "32 E Babcock St";

        public bool ShowDownloadApplication => true;

        public NamedValues TenantInfoDocs => new NamedValues(new Dictionary<string, string>()
        {
            { "Offline PDF application", "application.pdf" }
        });

        private MailSettings _mailSettings = new MailSettings()
        {
            SMTPServer = "sm13.internetmailserver.net",
            SMTPUsername = "Application@apexpropertiesmt.com",
            SMTPPw = "Tr3a7forU!",
            SMTPPort = 25,
            SMTPTo = "rental.application406@gmail.com"
        };
    }
}