using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterview.FactoryPattern
{
    public class SMSNotification : INotification
    {
        public string NotifyUser()
        {
            return "SMS Notification";
        }
    }
}
