using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smastad.Models
{
  [Table("Errand")]
  public class Errand
  {
      [Key]
      public int ErrandId { get; set; }

      //år-45-löpnummer ex. 2018-45-0024
      [Column("RefNumber")]
      public string RefNumber { get; set; }

      [Column("Place"), Required(ErrorMessage = "Var har brottet skett någonstans?")]
      public string Place { get; set; }

      [Column("TypeOfCrime"), Required(ErrorMessage = "Vilken typ av brott")]
      public string TypeOfCrime { get; set; }

      [Column("DateOfObsveration"), Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd})")]
      public DateTime DateOfObservation { get; set; }

      [Column("Observation")]
      public string Observation { get; set; }

      [Column("InvestigatorInfo")]
      [Required(ErrorMessage = "Vem är handlägare")]
      public string InvestigatorInfo { get; set; }

      [Column("InvestigatorAction")]
      public string InvestigatorAction { get; set; }

      [Column("InformerName"), Required(ErrorMessage = "Ditt namn")]
      public string InformerName { get; set; }

      [Column("InformerPhone"), Required(ErrorMessage = "Din telefon"), RegularExpression(pattern: @"^[0]{1}[0-9]{1,3}-[0-9]{5,9}$")]
      public string InformerPhone { get; set; }
      
      [ForeignKey("ErrandStatusId")]
      public string StatusId { get; set; }

      [ForeignKey("DepartmentId")]
      public string DepartmentId { get; set; }

      [ForeignKey("EmployeeId")]
      public string EmployeeId { get; set; }
  }
}
