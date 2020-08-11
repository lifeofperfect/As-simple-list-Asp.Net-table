using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cpuntries.Models
{
    public class CarsRank
    {
        /// <summary>
        /// lis of cars their prices score and mpg
        /// </summary>
        public string Car { get; set; }
        public string Price { get; set; }

        public string Score { get; set; }

        public string MPG { get; set; }
    }
}