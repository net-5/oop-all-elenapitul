﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_All.Interfaces
{
    interface ICrawl
    {
        void Crawl();
        int Speed { get; set; }
    }
}
