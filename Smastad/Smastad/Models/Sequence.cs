using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smastad.Models
{
    [Table("Sequence")]
    public class Sequence
    {
      [Key]
      public int Id { get; set; }

      //currentValue startar med talet 200
      [Column("CurrentValue")]
      public int CurrentValue { get; set; }
    }
}
 