using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smastad.Models
{
    [Table("ErrandStatus")]
    public class ErrandStatus
    {
      [Key]
      public string StatusId { get; set; }
      
      [Column("StatusName")]
      public string StatusName { get; set; }

    }
}
