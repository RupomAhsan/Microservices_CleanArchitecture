using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Utility.Helpers
{
    public class LocalizedDescriptionAttribute:DescriptionAttribute
    {
        private readonly string _Description;
        public LocalizedDescriptionAttribute(string resourceKey)
        {
            _Description = resourceKey;
        }
        public override string Description
        {
            get
            {
                return _Description;
            }
        }
    }
    public class LocalizedDescriptionValueAttribute : DescriptionAttribute
    {
        private readonly string _Description;
        public LocalizedDescriptionValueAttribute(string resourceKey)
        {
            _Description = resourceKey;
        }
        public override string Description
        {
            get
            {
                return _Description;
            }
        }
    }
}
