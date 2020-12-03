using Microsoft.Azure.NotificationHubs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Console.Azure.PushNotifications.Constant.AppConstant;

namespace Console.Azure.PushNotifications
{
    public class NotificationHubService
    {

        private NotificationHubClient hub { get; set; }

        public NotificationHubService()
        {
            hub = NotificationHubClient.
                CreateClientFromConnectionString(ListenConnectionString, NotificationHubName, false);
        }

        public NotificationOutcome SendFcmNativeNotificationAsync()
        {
            var dictionary = new Dictionary<string, string>()
                        {
                            { "title","Hello EAA Users"},
                            { "body","This is test notification for Infinix X573. please ignore"}
                        };

            string jsonPayload = "{\"data\": {\"message\":" + JsonConvert.SerializeObject(dictionary) + "}}";

            var tags = new List<string>();
            //if (tags != null && tags.Count > 0)
            //    return hub.SendFcmNativeNotificationAsync(jsonPayload, tags).Result;
            //else
            //    return hub.SendFcmNativeNotificationAsync(jsonPayload).Result;

            return null;

        }


    }
}
