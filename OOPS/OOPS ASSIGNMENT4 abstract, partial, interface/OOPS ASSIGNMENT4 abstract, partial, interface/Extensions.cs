﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_ASSIGNMENT4_abstract__partial__interface
{
    public static class Extensions
    {
        public static bool IsEven( this int number)
        { 
            return number % 2 == 0; 
        }
    }
}
