using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smastad.Models
{
    [Table("Picture")]
    public class Picture
    {
      [Key]
      public int PictureId { get; set; }

      [Column("PictureName", TypeName = "ntext")]
      public string PictureName { get; set; }

      [ForeignKey("ErrandId")]
      public int ErrandId { get; set; }
    }
}
