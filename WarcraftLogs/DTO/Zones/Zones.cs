using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftLogs.DTO.Zones
{
    public class Zones
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool frozen { get; set; }
        public Encounter[] encounters { get; set; }
        public Bracket[] brackets { get; set; }
    }

    public class Encounter
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Bracket
    {
        public int id { get; set; }
        public string name { get; set; }
    }

}
