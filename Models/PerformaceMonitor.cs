using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJSrenovationWeb.Models
{
    public abstract class PerformaceMonitor
    {
      public  int Target { get; set; }
        public int Actual { get; set; }
    }
}
