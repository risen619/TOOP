using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebApplication1.Helpers
{
    public static class CultureHelper
    {
        private static readonly List<string> _validCultures = new List<string> { "en", "en-us", "ru" };
        
        private static readonly List<string> _cultures = new List<string> { "en-us", "ru" };


        public static string GetImplementedCulture(string name)
        {
            if (string.IsNullOrEmpty(name))
                return GetDefaultCulture();

            name = name.ToLower();

            if (_cultures.Where(c => c.Equals(name)).Count() > 0)
                return name; 

            var n = GetNeutralCulture(name);
            foreach (var c in _cultures)
                if (c.StartsWith(n))
                    return c;

            return GetDefaultCulture();
        }

        public static string GetDefaultCulture()
        {
            return _cultures[0];
        }

        public static string GetCurrentCulture()
        {
            return Thread.CurrentThread.CurrentCulture.Name;
        }

        public static string GetCurrentNeutralCulture()
        {
            return GetNeutralCulture(Thread.CurrentThread.CurrentCulture.Name);
        }

        public static string GetNeutralCulture(string name)
        {
            if (!name.Contains("-")) return name;

            return name.Split('-')[0];
        }
    }
}