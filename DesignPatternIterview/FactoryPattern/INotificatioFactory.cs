using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterview.FactoryPattern
{
    abstract class NotificatioFactory
    {
        public abstract INotification CreateNotification(string type);
    }
}
