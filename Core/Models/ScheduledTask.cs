﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Core.Models
{
    public class ScheduledTask : ModelBase
    {
        public int TaskId { get; set; }
        public int DateId { get; set; }
        public int StatusId { get; set; }
    }
}
