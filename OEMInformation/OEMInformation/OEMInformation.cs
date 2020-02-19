using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEMInformation
{
    public class OEMInformation
    {
        public string Logo { get; private set; }
        public string Manufacturer { get; private  set; }
        public string Model { get; private set; }
        public string StartHours { get; private set; }
        public string EndHours { get; private set; }
        public string SupportPhone { get; private set; }
        public string SupportURL { get; private set; }

        public OEMInformation() {}
        public OEMInformation(string logo, string manufacturer, string model,string startHours, string endHours, string supportPhone, string supportURL)
        {
            Logo = logo;
            Manufacturer = manufacturer;
            Model = model;
            StartHours = startHours;
            EndHours = endHours;
            SupportPhone = supportPhone;
            SupportURL = supportURL;
        }

        

    }
}
