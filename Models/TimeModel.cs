using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kylan.space.Models
{
    public class TimeModel
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public int milliSeconds { get; set; }
        public string? dateTime { get; set; }
        public string? date { get; set; }
        public string? time { get; set; }
        public string? timeZone { get; set; }
        public string? dayOfWeek { get; set; }
        public bool dstActive { get; set; }
    }
}
