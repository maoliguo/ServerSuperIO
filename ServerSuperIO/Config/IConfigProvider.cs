﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerSuperIO.Config
{
    public interface IConfigProvider
    {
        IConfig Config { get; }
    }
}
