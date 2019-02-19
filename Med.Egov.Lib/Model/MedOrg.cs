using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med.Egov.Lib.Model
{
    public class MedOrg
    {
        public string name { get; set; }
        public string address { get; set; }
        public List<Patient> patients = null;
        public MedOrg():this("","")
        {
            
        }
        public MedOrg(string name,string address)
        {
            this.name = name;
            this.address = address;
            patients = new List<Patient>();
        }

    }
}
