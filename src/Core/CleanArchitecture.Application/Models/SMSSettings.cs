using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Models
{
    public class SMSSettings
    {
        public string AvailableCountryCodes { get; set; }
        public string BaseUrl { get; set; }
        public string EndPoint { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string From { get; set; }
        public int Validity { get; set; } = 0;
    }
}
