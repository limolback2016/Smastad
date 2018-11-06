using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smastad.Models
{
    [Table("Sample")]
    public class Sample
    {
      [Key]
      public int SampleId { get; set; }

      [Column("Name", TypeName = "ntext")]   
      [MaxLength(20)]
      public string SampleName { get; set; }

      [ForeignKey("ErrandId")]
      public int ErrandId { get; set; }
    }
}
