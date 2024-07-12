using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_delivery
{
    public class NotificationService
    {
        Dictionary<EVENT_TYPE.Type, List<Listener>> customers;

        public NotificationService()
        {
            customers = new Dictionary<EVENT_TYPE.Type, List<Listener>>();
            foreach (EVENT_TYPE.Type eventType in Enum.GetValues(typeof(EVENT_TYPE.Type)))
            {
                customers[eventType] = new List<Listener>();
            }
        }

        public void addListeners(EVENT_TYPE.Type event_type, Listener listener)
        {
            if (!customers.ContainsKey(event_type))
            {
                customers[event_type] = new List<Listener>();
            }
            customers[event_type].Add(listener);
        }

        public void removeListeners(EVENT_TYPE.Type event_type, Listener listener) 
        {
            if (customers.ContainsKey(event_type))
            {
                customers[event_type].Remove(listener);
            }
            
        }

        public void notifyCustomers(EVENT_TYPE.Type eventType)
        {
            if (customers.ContainsKey(eventType))
            {
                foreach (var listener in customers[eventType])
                {
                    listener.update(eventType);
                }
            }
        }
    }
}
