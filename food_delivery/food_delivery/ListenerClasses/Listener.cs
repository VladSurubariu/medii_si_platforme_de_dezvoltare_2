using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_delivery
{
    public interface Listener
    {
        void update(EVENT_TYPE.Type event_type);
    }
}
