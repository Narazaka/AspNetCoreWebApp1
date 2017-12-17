using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace AspNetCoreWebApp1
{
    public class ApplicationLogging
    {
        public static ILoggerFactory LoggerFactory { get; } = new LoggerFactory().AddConsole();

        public static ILogger CreateLogger<T>() => LoggerFactory.CreateLogger<T>();
    }
}
