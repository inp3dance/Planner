using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Core.Services
{
    public interface IPlannerDataService
    {
        Repositories.IPlannerDataRepository Data { get; set; }
    }
}
