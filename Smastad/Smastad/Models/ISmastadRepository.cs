using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smastad.Models
{
    public interface ISmastadRepository
    {
        IQueryable<Employee> Employees { get; }
        
        IQueryable<Errand> Errands { get; }

        IQueryable<Department> Departments { get; }

        IQueryable<ErrandStatus> ErrandStatuses { get; }

    }
}
