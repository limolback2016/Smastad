using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smastad.Models
{
  public class EFSmastadRepository  //fake repo for using faked data
  {
    private ApplicationDbContext context;

    public EFSmastadRepository(ApplicationDbContext ctx)
    {
      context = ctx;
    }

    public IQueryable<Employee> Employees => context.Employees;

    public IQueryable<Errand> Errands => context.Errands;

    public IQueryable<Department> Departments => context.Departments;

    public IQueryable<ErrandStatus> ErrandStatuses => context.ErrandStatuses;

    public IQueryable<Picture> Pictures => context.Pictures;

    public IQueryable<Sample> Samples => context.Samples;

    public IQueryable<Sequence> Sequences => context.Sequences;

    //Hämta ut department uppgifter
    public Task<Department> GetDepartment(int id)
    {
      return Task.Run(() =>
      {
        var departmentDetail = Departments.Where(td => td.DepartmentId.Equals(id)).First();
        return departmentDetail;
      });
    }
  }
}
