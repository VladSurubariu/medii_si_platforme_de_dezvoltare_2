using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_delivery
{
    public class Event
    {
        public EVENT_TYPE.Type type { get; set; }

        public Event(EVENT_TYPE.Type type)
        { 
            this.type = type;
        }
    }
}
