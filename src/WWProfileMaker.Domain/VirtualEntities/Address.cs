using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWProfileMaker.Domain.VirtualEntities
{
    public abstract class Address
    {
        public string street { get; set; }
        public int number { get; set; }
        public string complement { get; set; }

        protected Address(string street, int number, string complement)
        {
            this.street = street;
            this.number = number;
            this.complement = complement;
        }
    }
}
