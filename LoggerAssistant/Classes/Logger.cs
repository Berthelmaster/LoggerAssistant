using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LoggerAssistant.Interfaces;
using LoggerAssistant.Model;

namespace LoggerAssistant.Classes
{
    public class Logger : ILogger
    {
        public async Task<bool> Log(string log, string category = null, bool isError = false)
        {
            HttpResponseMessage response;

            Log localLog = new Log {
                Id = Guid.NewGuid().ToString(),
                CustomerProject = Assembly.GetCallingAssembly().GetName().Name,
                isError = isError,
                Logs = log
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("123123123");
                response = await client.PostAsJsonAsync("api/customerLogging", localLog);
            }

            if(response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }
    }
}
