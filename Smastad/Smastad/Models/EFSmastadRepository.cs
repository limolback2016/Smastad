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
    
    //Hämta ut Employee uppgifter
    public Task<Employee> GetEmployee(int id)
    {
        return Task.Run(() =>
        {
            var employeeDetail = Employees.Where(td => td.EmployeeId.Equals(id)).First();
                return employeeDetail;
        });
    }

    public Task<Errand> GetErrand(int id)
    {
        return Task.Run(() =>
        {
            var errandDetail = Errands.Where(td => td.ErrandId.Equals(id)).First();
            return errandDetail;
        });
    }

    public Task<ErrandStatus> GetErrandStatus(int id)
    {
        return Task.Run(() =>
        {
            var errandStatusDetail = ErrandStatuses.Where(td => td.StatusId.Equals(id)).First();
            return errandStatusDetail;
        });
    }

    public Task<Picture> GetPicture(int id)
    {
        return Task.Run(() =>
        {
            var pictureDetail = Pictures.Where(td => td.PictureId.Equals(id)).First();
            return pictureDetail;
        });
    }

    public Task<Sample> GetSample(int id)
    {
        return Task.Run(() =>
        {
            var sampleDetail = Samples.Where(td => td.SampleId.Equals(id)).First();
            return sampleDetail;
        });
    }
    
    public Task<Sequence> GetSequence(int id)
    {
        return Task.Run(() =>
        {
            var sequenceDetail = Sequences.Where(td => td.Id.Equals(id)).First();
            return sequenceDetail;
        });
    }
     
}
}

