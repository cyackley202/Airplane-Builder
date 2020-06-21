﻿using PlaneBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneBuilder.Services
{
    public interface ITSAClient
    {
        Task<TSAWaitTime> GetAirport(string airport);
    }
}
