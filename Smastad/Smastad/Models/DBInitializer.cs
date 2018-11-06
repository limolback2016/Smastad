using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smastad.Models
{
  public class DBInitializer
  {
    public static void EnsurePopulated(ApplicationDbContext context)
    {
      //koll om tabellen deparment är tom och i så fall fyll på med data
      if (!context.Departments.Any())
      {
        context.Departments.AddRange(
          new Department { DepartmentId = "D00", DepartmentName = "Småstads kommun" },
          new Department { DepartmentId = "D01", DepartmentName = "Tekniska Avloppshanteringen" },
          new Department { DepartmentId = "D02", DepartmentName = "Klimat och Energi" },
          new Department { DepartmentId = "D03", DepartmentName = "Natur och Skogsvård" },
          new Department { DepartmentId = "D04", DepartmentName = "Miljö och Hälsoskydd" },
          new Department { DepartmentId = "D05", DepartmentName = "Renhållning och Avfall" }
        );
        context.SaveChanges(); //spara tabellen
      }

      if (!context.Employees.Any())
      {
        context.Employees.AddRange(
          new Employee { EmployeeId = "E001", EmployeeName = "Östen Ärling", RoleTitle = "Coordinator", DepartmentId = "D00" },
          new Employee { EmployeeId = "E100", EmployeeName = "Anna Åkerman", RoleTitle = "Manager", DepartmentId = "D01" },
          new Employee { EmployeeId = "E101", EmployeeName = "Fredrik Roos", RoleTitle = "Investigator", DepartmentId = "D01" },
          new Employee { EmployeeId = "E102", EmployeeName = "Gösta Qvist", RoleTitle = "Investigator", DepartmentId = "D01" },
          new Employee { EmployeeId = "E103", EmployeeName = "Hilda Persson", RoleTitle = "Investigator", DepartmentId = "D01" },
          new Employee { EmployeeId = "E200", EmployeeName = "Bengt Viik", RoleTitle = "Manager", DepartmentId = "D02" },
          new Employee { EmployeeId = "E201", EmployeeName = "Ivar Oscarsson", RoleTitle = "Investigator", DepartmentId = "D02" },
          new Employee { EmployeeId = "E202", EmployeeName = "Jenny Nordström", RoleTitle = "Investigator", DepartmentId = "D02" },
          new Employee { EmployeeId = "E203", EmployeeName = "Kurt Mild", RoleTitle = "Investigator", DepartmentId = "D02" },
          new Employee { EmployeeId = "E300", EmployeeName = "Cecilia Unosson", RoleTitle = "Manager", DepartmentId = "D04" },
          new Employee { EmployeeId = "E301", EmployeeName = "Lena Larsson", RoleTitle = "Investigator", DepartmentId = "D04" },
          new Employee { EmployeeId = "E302", EmployeeName = "Martin Kvist", RoleTitle = "Investigator", DepartmentId = "D04" },
          new Employee { EmployeeId = "E303", EmployeeName = "Nina Jansson", RoleTitle = "Investigator", DepartmentId = "D04" },
          new Employee { EmployeeId = "E400", EmployeeName = "David Trastlund", RoleTitle = "Manager", DepartmentId = "D03" },
          new Employee { EmployeeId = "E401", EmployeeName = "Oskar Ivarsson", RoleTitle = "Investigator", DepartmentId = "D03" },
          new Employee { EmployeeId = "E402", EmployeeName = "Petra Hermansdotter", RoleTitle = "Investigator", DepartmentId = "D03" },
          new Employee { EmployeeId = "E403", EmployeeName = "Rolf Gunnarsson", RoleTitle = "Investigator", DepartmentId = "D03" },
          new Employee { EmployeeId = "E500", EmployeeName = "Emma Svanberg", RoleTitle = "Manager", DepartmentId = "D05" },
          new Employee { EmployeeId = "E501", EmployeeName = "Susanne Fred", RoleTitle = "Investigator", DepartmentId = "D05" },
          new Employee { EmployeeId = "E502", EmployeeName = "Torsten Embjörn", RoleTitle = "Investigator", DepartmentId = "D05" },
          new Employee { EmployeeId = "E503", EmployeeName = "Ulla Davidsson", RoleTitle = "Investigator", DepartmentId = "D05" }
        );
        context.SaveChanges(); //spara tabellen
      }

      if (!context.ErrandStatuses.Any())
      {
        context.ErrandStatuses.AddRange(
          new ErrandStatus { StatusName = "Inrapporterad"},
          new ErrandStatus { StatusName = "Ingen åtgärd"},
          new ErrandStatus { StatusName = "Påbörjad"},
          new ErrandStatus { StatusName = "Klar"}
        );
        context.SaveChanges(); //spara tabellen
      }

    }
  }
}
