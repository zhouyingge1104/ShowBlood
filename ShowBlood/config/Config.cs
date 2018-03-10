using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ShowBlood.config
{
    class Config
    {
        public string port, portTest; 
        public string baudrate, baudrateTest;

        public Config()
        {
            port = "";
            baudrate = "";
            portTest = "";
            baudrateTest = "";
        }

        public Config(JObject obj)
        {
            port = (string)obj["port"];
            baudrate = (string)obj["baudrate"];
            portTest = (string)obj["portTest"];
            baudrateTest = (string)obj["baudrateTest"];
        }

    }
}
