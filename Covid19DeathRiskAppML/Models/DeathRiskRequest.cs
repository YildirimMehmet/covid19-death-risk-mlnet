using System.ComponentModel.DataAnnotations;

namespace Covid19DeathRiskAppML.Models
{
    public class DeathRiskRequest
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        [Display(Name = "Erkek")]
        Male,
        [Display(Name = "Kadın")]
        Female
    }
}
