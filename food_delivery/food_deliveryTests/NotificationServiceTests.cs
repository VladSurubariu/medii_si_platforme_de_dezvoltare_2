using Microsoft.VisualStudio.TestTools.UnitTesting;
using food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_delivery.Tests
{
    [TestClass()]
    public class NotificationServiceTests
    {
        [TestMethod()]
        public void addListenersTest()
        {
            NotificationService notificationService = new NotificationService();
            notificationService.addListeners(EVENT_TYPE.Type.FOOD_ORDERED, new CookListener("2"));

            Assert.IsTrue(notificationService.customers[EVENT_TYPE.Type.FOOD_ORDERED].Count == 1);
        }

        [TestMethod()]
        public void removeListeners()
        {
            NotificationService notificationService = new NotificationService();

            notificationService.addListeners(EVENT_TYPE.Type.FOOD_ORDERED, new CookListener("2"));
            notificationService.addListeners(EVENT_TYPE.Type.FOOD_ORDERED, new CookListener("3"));

            Assert.IsTrue(notificationService.customers[EVENT_TYPE.Type.FOOD_ORDERED].Count == 1);

            notificationService.removeListeners(EVENT_TYPE.Type.FOOD_ORDERED);

            Assert.IsTrue(notificationService.customers[EVENT_TYPE.Type.FOOD_ORDERED].Count == 0);

            notificationService.notifyCustomers(EVENT_TYPE.Type.FOOD_ORDERED);
        }
    }
}