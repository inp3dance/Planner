using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Core.Repositories
{
    public interface IDatesRepository : IRepository<Models.Date>
    {
        IEnumerable<Models.ScheduledTask> ScheduledTasks { get; set; }
    }
}
