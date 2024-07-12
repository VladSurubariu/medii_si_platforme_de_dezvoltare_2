using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_delivery
{
    public class ChickenBurger : Burger
    {
        public void prepare()
        {
            MessageBox.Show("Your chicken burger is ordered!");
        }
    }
}
