using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterview.DataLayer.Model
{
    public sealed class GlobalDbConnection
    {
        public static string Connection{
            get {
                return ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;
            }
        
        
        }
    }
}
