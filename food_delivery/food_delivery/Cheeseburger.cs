using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_delivery
{
    public class Cheeseburger : Burger
    {
        public void prepare()
        {
            MessageBox.Show("Your cheeseburger is ordered!");
        }
    }
}
