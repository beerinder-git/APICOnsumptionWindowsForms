using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class DataCovid
    {
        public int recovered { get; set; }
        public int deaths { get; set; }
        public int confirmed { get; set; }
        public DateTime lastChecked { get; set; }
        public DateTime lastReported { get; set; }
        public string location { get; set; }
    }
}
