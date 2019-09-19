using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTraveler.Classes
{
    public class EventViewModel
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateExpired { get; set; }
    }
}
