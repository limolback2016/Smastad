using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smastad.Models
{
    [Table("Department")]
    public class Department
    {
      [Key]
      public string DepartmentId { get; set; }
      
      [Column("DepartmentName", TypeName = "ntext")]
      public string DepartmentName { get; set; }
    }
}
