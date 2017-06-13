using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftLogs.DTO.Classes
{
    public class Classes
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Spec> specs { get; set; }
    }

    public class Spec
    {
        public int id { get; set; }
        public string name { get; set; }
    }

}
