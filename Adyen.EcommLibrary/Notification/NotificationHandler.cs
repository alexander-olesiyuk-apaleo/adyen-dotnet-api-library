﻿using System;
using System.Collections.Generic;
using System.Text;
using Adyen.EcommLibrary.Model.Notification;
using Adyen.EcommLibrary.Util;
using Newtonsoft.Json.Linq;

namespace Adyen.EcommLibrary.Notification
{
    public class NotificationHandler
    {
        public NotificationRequest HandleNotificationRequest(string jsonRequest)
        {
            var notificationRequest = JsonOperation.Deserealize(jsonRequest);
            
            

            //var notificationRequest = new NotificationRequest {Live = (bool)live};
            //var live = notificationRequestdynamic.live;

            //var notification = notificationRequestdynamic.notificationItems;

            return null;
        }
    }
}
