using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Smastad.Models
{
  public class Errand
  {
      [Display(Name = "Fullständigt namn")]
      [Required(ErrorMessage = "Du måste fylla i ditt namn")]
      public string ErrandId { get; set; }

      [Display(Name = "Var har brottet skett någonstans?")]
      [Required(ErrorMessage = "Du måste ange adressen")]
      public string Place { get; set; }

      [Display(Name = "Vilken typ av brott")]
      [Required(ErrorMessage = "Anger typ av brott")]
      public string TypeOfCrime { get; set; }

      [Display(Name = "När skedde brottet")]
      [Required(ErrorMessage = "Datum saknas")]
      public DateTime DateOfObservation { get; set; }

      [Display(Name = "Beskriv din observation")]
      public string Observation { get; set; }

      [Display(Name = "Handlägare")]
      [Required(ErrorMessage = "Vem är handlägare")]
      public string InvestigatorInfo { get; set; }

      [Display(Name = "Händelser: ")]
      [Required(ErrorMessage = "Beskrivningen av händelser saknas")]
      public string InvestigatorAction { get; set; }

      [Display(Name = "Ditt namn")]
      [Required(ErrorMessage = "Du måste fylla i ditt namn")]
      public string InformerName { get; set; }

      [Display(Name = "Din telefon")]
      [Required(ErrorMessage = "Kontakt info måste fylla i här")]
      [RegularExpression(pattern: @"^[0]{1}[0-9]{1,3}-[0-9]{5,9}$")]
      public string InformerPhone { get; set; }

      [Display(Name = "Välj status")]
      [Required(ErrorMessage = "StatusId måste anges")]
      [RegularExpression(pattern: @"^[sS_A - D] * $")]
      public string StatusId { get; set; }

      [Display(Name = "Välj avdelning")]
      [Required(ErrorMessage = "Vilken avdelning tillhör ärenden")]
      [RegularExpression(pattern: @"^[dD]{1}[0]{1}[0-3]*$")]
      public string DepartmentId { get; set; }

      [Display(Name = "HandläggarensId")]
      [Required(ErrorMessage = "HandläggarensId måste fylla i")]
      [RegularExpression(pattern: @"[eE]{1}[30-50]*[1-2].$  ")]
      public string EmployeeId { get; set; }
  }
}
