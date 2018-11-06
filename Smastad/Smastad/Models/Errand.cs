using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Smastad.Models
{
  public class Errand
  {
      public int ErrandId { get; set; }

      //år-45-löpnummer ex. 2018-45-0024
      public string RefNumber { get; set; }
    
      [Required(ErrorMessage = "Var har brottet skett någonstans?")]
      public string Place { get; set; }

      [Required(ErrorMessage = "Vilken typ av brott")]
      public string TypeOfCrime { get; set; }

      [Required(ErrorMessage = "När skedde brottet")]
      [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
      public DateTime DateOfObservation { get; set; }

      public string Observation { get; set; }

      [Required(ErrorMessage = "Vem är handlägare")]
      public string InvestigatorInfo { get; set; }

      public string InvestigatorAction { get; set; }

      [Required(ErrorMessage = "Ditt namn")]
      public string InformerName { get; set; }

      [Required(ErrorMessage = "Din telefon")]
      [RegularExpression(pattern: @"^[0]{1}[0-9]{1,3}-[0-9]{5,9}$")]
      public string InformerPhone { get; set; }

      public string StatusId { get; set; }

      public string DepartmentId { get; set; }

      public string EmployeeId { get; set; }
  }
}
