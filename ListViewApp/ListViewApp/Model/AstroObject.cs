﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewApp.Model
{
    //public enum AstroObjectType { Planet, Meteoroid, Star, BlackHole, Moon }
    public class AstroObject
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
