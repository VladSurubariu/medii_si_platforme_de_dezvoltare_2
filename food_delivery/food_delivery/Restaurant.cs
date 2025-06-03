using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace food_delivery
{
    public class Restaurant
    {
        private NotificationService notificationService;

        public Restaurant()
        {
            notificationService = new NotificationService();
        }
        public NotificationService getNotificationService()
        {
            return notificationService;
        }

        public void foodIsOrderedNotification()
        {
            notificationService.notifyCustomers(EVENT_TYPE.Type.FOOD_ORDERED);
        }
        public void foodIsCookingNotification()
        {
            notificationService.notifyCustomers(EVENT_TYPE.Type.FOOD_COOKING);
        }
        public void foodIsReadyNotification()
        {
            notificationService.notifyCustomers(EVENT_TYPE.Type.FOOD_READY);
        }
        
    }
}
