using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_delivery
{
    public abstract class RestaurantFood
    {
        public void orderBurger()
        {
            // update text box 
            Burger burger = createBurger();
            burger.prepare();
        }

        public abstract Burger createBurger();
    }
}
