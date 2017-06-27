using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume
{
    public sealed class AppLocationFinder
    {
        private AppLocationFinder()
        {
        }

        public static string Current
        {
            get
            {
                string v_currentLocation = AppDomain.CurrentDomain.BaseDirectory;
                if (!string.IsNullOrWhiteSpace(v_currentLocation))
                {
                    if (v_currentLocation.Contains("\\bin\\"))
                        return v_currentLocation.Substring(0, v_currentLocation.LastIndexOf("\\bin", StringComparison.InvariantCultureIgnoreCase));
                    else
                        return v_currentLocation;
                }
                throw new Exception("Unable to find your app !");
            }
        }
    }
}
