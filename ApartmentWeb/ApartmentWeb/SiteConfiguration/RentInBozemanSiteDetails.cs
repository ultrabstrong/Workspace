using BusinessLayer.Core;
using KelleyUtilities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentWeb.SiteConfiguration
{
    public class RentInBozemanSiteDetails : ISiteDetails
    {
        public string CompanyName => "Rent In Bozeman";

        public string CompanyShortName => "RentInBozeman";

        public string EmailAddress => "rentinbozeman@gmail.com";

        public string PhoneNumber => "406-595-2965";

        public string Address => "PO Box 5232 Bozeman 59717";

        public MailSettings MailSettings => _mailSettings;

        public bool ShowTrash => true;

        public string PostOfficeAddress => $"2201 Baxter Lane{Environment.NewLine}- OR -{Environment.NewLine}32 E Babcock St";

        public bool ShowDownloadApplication => false;

        public NamedValues TenantInfoDocs => null;

        private MailSettings _mailSettings = new MailSettings()
        {
            SMTPServer = "sm04.internetmailserver.net",
            SMTPUsername = "Application@rentinbozeman.net",
            SMTPPw = "snowC@pp3dPeeks",
            SMTPPort = 25,
            SMTPTo = "rentinbozeman@gmail.com"
        };
    }
}