using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Database
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MapperAtrribute : Attribute
    {
        public string HeaderName { get; set; }
    }
}