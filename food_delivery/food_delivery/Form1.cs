using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_delivery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestaurantFood burger_order = new ChickenBurgerRestaurantFood();
            burger_order.orderBurger();

            Restaurant restaurant = new Restaurant();
            restaurant.getNotificationService().addListeners(EVENT_TYPE.Type.FOOD_ORDERED, new CookListener("3"));
            restaurant.getNotificationService().addListeners(EVENT_TYPE.Type.FOOD_ORDERED, new ClientListener("9"));

            restaurant.foodIsOrderedNotification();

            restaurant.getNotificationService().removeListeners(EVENT_TYPE.Type.FOOD_ORDERED, new CookListener("3"));
            restaurant.getNotificationService().removeListeners(EVENT_TYPE.Type.FOOD_ORDERED, new ClientListener("9"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestaurantFood burger_order = new BeefBurgerRestaurantFood();
            burger_order.orderBurger();

            Restaurant restaurant = new Restaurant();
            restaurant.getNotificationService().addListeners(EVENT_TYPE.Type.FOOD_ORDERED, new CookListener("2"));
            restaurant.getNotificationService().addListeners(EVENT_TYPE.Type.FOOD_ORDERED, new ClientListener("11"));

            restaurant.foodIsOrderedNotification();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestaurantFood burger_order = new CheeseburgerRestaurantFood();
            burger_order.orderBurger();

            Restaurant restaurant = new Restaurant();
            restaurant.getNotificationService().addListeners(EVENT_TYPE.Type.FOOD_ORDERED, new CookListener("1"));
            restaurant.getNotificationService().addListeners(EVENT_TYPE.Type.FOOD_ORDERED, new ClientListener("6"));

            restaurant.foodIsOrderedNotification();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant();

            restaurant.getNotificationService().addListeners(EVENT_TYPE.Type.FOOD_COOKING, new ClientListener("9"));

            restaurant.foodIsCookingNotification();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant();

            restaurant.getNotificationService().addListeners(EVENT_TYPE.Type.FOOD_READY, new ClientListener("9"));

            restaurant.foodIsReadyNotification();
        }
    }
}
