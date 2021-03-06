﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorModel
{
    public class InitialStatisticsMessage
    {
        public ReadOnlyDictionary<string, int> PlayCounts { get; private set; }

        public InitialStatisticsMessage(ReadOnlyDictionary<string, int> playCounts)
        {
            PlayCounts = playCounts;
        }
    }
}