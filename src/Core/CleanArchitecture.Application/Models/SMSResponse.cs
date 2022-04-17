using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Models
{

    public class ArrayOfServiceClass
    {
        public ArrayList ServiceClass { get; set; }
        
    }
    public class ServiceClass
    {
        public string MessageID { get; set; }
        public int Status { get; set; }
        public string StatusText  { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorText { get; set; }
        public int SMSCount { get; set; }
        public decimal CurrentCredit { get; set; }
    }
}
