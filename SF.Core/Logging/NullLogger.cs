﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Core
{
    public class NullLogger : ILogger
    {
        public void Log(string message)
        {
            return;
        }
    }
}
