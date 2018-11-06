using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smastad.Models
{
    [Table("Employee")]
    public class Employee
    {
      [Key]
      public string EmployeeId { get; set; }

      [Column("EmployeeName", TypeName = "ntext")]
      [MaxLength(50)]
      public string EmployeeName { get; set; }

      [Column("RoleTitle")]
      [MaxLength(20)]
      public string RoleTitle { get; set; }
      
      [ForeignKey("DepartmentId")]
      public string DepartmentId { get; set; }
  }
}
