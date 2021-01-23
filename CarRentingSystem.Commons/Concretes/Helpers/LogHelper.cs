﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Commons.Abstractions;
using CarRentingSystem.Commons.Concretes.Logger;
using System.Configuration;

namespace CarRentingSystem.Commons.Concretes.Helpers
{
    public class LogHelper
    {
        private static LogBase _logger = null;
        private static bool _enableLogging = bool.Parse(ConfigurationManager.AppSettings["EnableLogging"]);
        public static void Log(LogTarget target, string message, bool isError = false)
        {
            if (_enableLogging)
            {
                switch (target)
                {
                    case LogTarget.File:
                        _logger = new FileLogger();
                        _logger.Log(message, isError);
                        break;
                    case LogTarget.Database:
                        _logger = new DBLogger();
                        _logger.Log(message, isError);
                        break;
                    case LogTarget.EventLog:
                        _logger = new EventLogger();
                        _logger.Log(message, isError);
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
