﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HTTPServer
{
    public interface IRoute
    {
        int Priority { get; }
        Task<bool> Execute(HttpListenerContext context);
    }
}
