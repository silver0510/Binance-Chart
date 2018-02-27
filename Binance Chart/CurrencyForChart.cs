using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance_Chart
{
    public class CurrencyForChart
    {
        public string market { get; set; }
        public DateTime openTime { get; set; }
        public float closePrice { get; set; }
        public float volume { get; set; }
    }
}
