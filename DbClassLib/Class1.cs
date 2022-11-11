using System;
using System.Configuration;

namespace DbClassLib
{
    public class DbClass
    {
        public string GetConnString()
        {
            string configvalue1 = ConfigurationManager.AppSettings["strSql"];
            return configvalue1;
        }
    }
}
