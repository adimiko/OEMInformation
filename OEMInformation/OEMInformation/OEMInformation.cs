using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEMInformation
{
    public class OEMInformation
    {
        public string Logo { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SupportHours { get; set; }
        public string SupportPhone { get; set; }
        public string SupportURL { get; set; }

        public OEMInformation() {}
        public OEMInformation(string logo, string manufacturer, string model,string supportHours, string supportPhone, string supportURL)
        {
            Logo = logo;
            Manufacturer = manufacturer;
            Model = model;
            SupportHours = supportHours;
            SupportPhone = supportPhone;
            SupportURL = supportURL;
        }

        public void SaveChanges()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation\", true);

            if(!string.IsNullOrWhiteSpace(Logo)) registryKey.SetValue("Logo", Logo);
            if (!string.IsNullOrWhiteSpace(Manufacturer)) registryKey.SetValue("Manufacturer", Manufacturer);
            if (!string.IsNullOrWhiteSpace(Model)) registryKey.SetValue("Model", Model);
            if (!string.IsNullOrWhiteSpace(SupportHours)) registryKey.SetValue("SupportHours", SupportHours);
            if (!string.IsNullOrWhiteSpace(SupportPhone)) registryKey.SetValue("SupportPhone", SupportPhone);
            if (!string.IsNullOrWhiteSpace(SupportURL)) registryKey.SetValue("SupporURL", SupportURL);

            registryKey.Close();
        }

    }
}
