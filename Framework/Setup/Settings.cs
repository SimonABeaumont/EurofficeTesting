﻿using System;
using System.Configuration;

namespace EuroOffice.Framework.Setup
{
    public static class Settings
    {
        public static readonly string Browser = ConfigurationManager.AppSettings["Browser"];
        public static readonly string CaptureLocation = ConfigurationManager.AppSettings["ErrorCaptureLocation"];
    }
}
