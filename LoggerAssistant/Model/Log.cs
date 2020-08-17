using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerAssistant.Model
{
    public class Log
    {
        public string Id { get; set; }
        public string Logs { get; set; }
        public bool isError { get; set; }

        public string CustomerProject { get; set; }
    }
}
