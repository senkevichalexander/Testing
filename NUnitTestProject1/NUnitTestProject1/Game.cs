﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SteamAutomationProject
{
    public class Game
    {
        public string Name { get; set; }
        public List<string> Genres { get; set; }
        public double Price { get; set; }
        public int Sale { get; set; }
    }
}
