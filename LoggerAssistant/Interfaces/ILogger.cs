using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LoggerAssistant.Model;

namespace LoggerAssistant.Interfaces
{
    internal interface ILogger
    {
        public Task<bool> Log(string log, string? category = null, bool isError = false);
    }
}
