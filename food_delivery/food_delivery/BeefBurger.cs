using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_delivery
{
    public class BeefBurger : Burger
    {
        public void prepare()
        {
            MessageBox.Show("Your beef burger is ordered!");
        }
    }
}
