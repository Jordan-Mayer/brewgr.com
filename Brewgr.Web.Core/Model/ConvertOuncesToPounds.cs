﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brewgr.Web.Core.Model
{
    public static class ConvertOuncesToPounds
    {
        public static double Convert(double ounces)
        { 
            return ounces / 16;
        }
    }
}
