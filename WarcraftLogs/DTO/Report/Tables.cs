using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarcraftLogs.DTO.Reports;

namespace WarcraftLogs.DTO.Report
{
    public class Tables
    {
        public string id { get; set; }
        public string title { get; set; }
        public string owner { get; set; }
        public int zone { get; set; }
        public int startTime { get; set; }
        public int endTime { get; set; }
    }
}
