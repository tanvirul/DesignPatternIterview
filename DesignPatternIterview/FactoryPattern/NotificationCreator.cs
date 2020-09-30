using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterview.FactoryPattern
{
    class NotificationCreator : NotificatioFactory
    {
        public override INotification CreateNotification(string type)
        {
            if (type == "SMS")
            {
                return new SMSNotification();
            }
            else if (type == "Email")
                return new EmailNotification();
            else
                return null;
        }
    }
}
