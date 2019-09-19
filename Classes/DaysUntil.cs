using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTraveler.Classes
{
    public class DaysUntil
    {
        public Dictionary<int, Event> Events { get; set; }

        public DaysUntil()
        {
            Events = new Dictionary<int, Event>();
        }
    }
}
