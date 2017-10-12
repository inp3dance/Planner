﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Core.Models
{
    public class Task : ModelBase
    {
        public int Name { get; set; }
        public int Description { get; set; }
        public List<string> Checklist { get; set; }
        public int TimeEstimate { get; set; }
        public int ParentId { get; set; }
        public int ProjectId { get; set; }
    }
}
