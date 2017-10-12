using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Core.Models;

namespace Planner.Core.Repositories
{
    // this is the Unit of Work
    public interface IPlannerDataRepository
    {
        IDatesRepository Dates { get; set; }
        IProjectsRepository Projects { get; set; }
        IScheduledTasksRepository ScheduledTasks { get; set; }
        IStatusRepository Status { get; set; }
        ITasksRepository Tasks { get; set; }
    }
}
