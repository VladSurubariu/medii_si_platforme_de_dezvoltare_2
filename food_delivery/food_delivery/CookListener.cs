using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_delivery
{
    public class CookListener : Listener
    {
        string id; 
        public CookListener(String id)
        {
            this.id = id;
        }

        public void update(EVENT_TYPE.Type event_type)
        {
            string msg = "The cook " + id + " has been informed about the event of type " + event_type.ToString();
            MessageBox.Show(msg);
        }
    }
}
