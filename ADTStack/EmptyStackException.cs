﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTStack
{
    class EmptyStackException : Exception
    {
        public EmptyStackException(string msg) : base(msg)
        {

        }

    }
}
