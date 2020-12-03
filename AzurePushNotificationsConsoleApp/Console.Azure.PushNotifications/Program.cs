using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Azure.PushNotifications
{
    class Program
    {
        private static DateTime _selectedDate = DateTime.MinValue;
        static void Main(string[] args)
        {
            if (_selectedDate == default(DateTime))
            {
                System.Console.WriteLine("Response received");
            }


            //var hubService = new NotificationHubService();

            //var response = hubService.SendFcmNativeNotificationAsync();

            System.Console.WriteLine("Response received");
            System.Console.ReadLine();

        }
    }
}
