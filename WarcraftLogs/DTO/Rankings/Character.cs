using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarcraftLogs.DTO.Generic;

namespace WarcraftLogs.DTO.Rankings
{
    public class Character
    {
        public int rank { get; set; }
        public int outOf { get; set; }
        public int total { get; set; }
        public int _class { get; set; }
        public int spec { get; set; }
        public string guild { get; set; }
        public int duration { get; set; }
        public int startTime { get; set; }
        public int itemLevel { get; set; }
        public int patch { get; set; }
        public string reportID { get; set; }
        public int fightID { get; set; }
        public int difficulty { get; set; }
        public int size { get; set; }
        public bool estimated { get; set; }
    }
}
