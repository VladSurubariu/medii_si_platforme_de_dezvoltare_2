using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_delivery
{
    public class ChickenBurgerRestaurantFood : RestaurantFood
    {
        public override Burger createBurger()
        {
            // update beef burger status
            return new ChickenBurger();
        }
    }
}
