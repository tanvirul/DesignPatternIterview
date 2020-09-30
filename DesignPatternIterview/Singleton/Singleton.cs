using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterview.Singleton
{
    public sealed class Singleton
    {
        private Singleton() { }
        private static readonly object padlock = new object();

        private static Singleton singleton = null;
        public static Singleton GetSingleton()
        {

            lock (padlock)
            {
                if (singleton == null)
                {
                    return new Singleton();
                }
                else
                    return singleton;
            }
            
        }
    }
}
