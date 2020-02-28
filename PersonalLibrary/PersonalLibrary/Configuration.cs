using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary
{
    class Configuration
    {
        public static string ServerName;
        public static string ConnectionString;
        public static MainForm mainForm = null;
        public static StartForm startForm = null;
        public static string path = @"c:\PersonalLibrary";
        public static string pathtxt = @"c:\PersonalLibrary\configuration.txt";
    }
}
