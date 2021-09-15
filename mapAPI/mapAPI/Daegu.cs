using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapAPI
{
    class Daegu
    {
        public string attractname { get; set; }
        public string tel { get; set; }
        public string address { get; set; }

        public Daegu(string attractname, string tel, string address)
        {
            this.attractname = attractname;
            this.tel = tel;
            this.address = address;
        }
    }
}
