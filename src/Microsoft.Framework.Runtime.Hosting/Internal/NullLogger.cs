﻿using System;
using Microsoft.Framework.Logging;

namespace Microsoft.Framework.Runtime.Hosting.Internal
{
    internal class NullLoggerFactory : ILoggerFactory
    {
        public static readonly NullLoggerFactory Instance = new NullLoggerFactory();

        private NullLoggerFactory() { }

        public LogLevel MinimumLevel { get; set; }

        public void AddProvider(ILoggerProvider provider)
        {
        }

        public ILogger Create(string name)
        {
            return NullLogger.Instance;
        }
    }

    internal class NullLogger : ILogger
    {
        public static readonly NullLogger Instance = new NullLogger();

        private NullLogger() { }

        public IDisposable BeginScope(object state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
        }

        public void Write(LogLevel logLevel, int eventId, object state, Exception exception, Func<object, Exception, string> formatter)
        {
        }
    }
}