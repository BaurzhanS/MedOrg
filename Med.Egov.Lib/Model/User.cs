using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med.Egov.Lib.Model
{
    public enum access { admin=1,user=0}
    public class User
    {
        public string login { get; set; }
        public string password { get; set; }
        public MedOrg medOrg { get; set; }
        public int access { get; set; }
    }
}
