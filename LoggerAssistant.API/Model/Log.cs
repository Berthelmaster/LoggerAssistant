using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggerAssistant.API.Model
{
    public class Log
    {
        public string Id { get; set; }
        public string Logs { get; set; }
        public bool isError { get; set; }
        public string CustomerProject { get; set; }
        public Account Account { get; set; }
    }
}
