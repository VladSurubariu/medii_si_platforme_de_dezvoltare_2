using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_delivery
{
    public class ClientListener : Listener
    {
        string id;
        public ClientListener(String id)
        {
            this.id = id;
        }

        public void update(EVENT_TYPE.Type event_type)
        {
            string msg = "The client " + id + " has been informed about the event of type " + event_type.ToString();
            MessageBox.Show(msg);
        }
    }
}
