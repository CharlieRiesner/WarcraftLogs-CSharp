using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftLogs.DTO.Rankings
{
    public class Encounter
    {
        public int total { get; set; }
        public Ranking[] rankings { get; set; }
    }

    public class Ranking
    {
        public string name { get; set; }
        public int total { get; set; }
        public int _class { get; set; }
        public int spec { get; set; }
        public string guild { get; set; }
        public string server { get; set; }
        public string region { get; set; }
        public int duration { get; set; }
        public int startTime { get; set; }
        public int damageTaken { get; set; }
        public int deaths { get; set; }
        public int itemLevel { get; set; }
        public int patch { get; set; }
        public string reportID { get; set; }
        public int fightID { get; set; }
        public Team[] team { get; set; }
        public int size { get; set; }
    }

    public class Team
    {
        public string name { get; set; }
        public int _class { get; set; }
        public int spec { get; set; }
    }

}
