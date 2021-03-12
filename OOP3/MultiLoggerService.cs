using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MultiLoggerService 
    {
        public void Log(List<ILoggerService> loggerServices)
        {
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
    }
}
