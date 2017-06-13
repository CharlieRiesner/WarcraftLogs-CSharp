using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftLogs.DTO.Generic
{
    public class Report
    {
        public string id { get; set; }
        public string title { get; set; }
        public string owner { get; set; }
        public int zone { get; set; }
        public int startTime { get; set; }
        public int endTime { get; set; }
    }
}
