using System.ComponentModel.DataAnnotations;

namespace TESTAPP.Models
{
    public class Doctor
    {
        [Key]
        public int doctor_id { get; set; }

        [Required]
        [Display(Name = "First name")]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[А-Я]+[а-я""'\s]*$", ErrorMessage = "Please enter 3 or more characters in Cyrillic, the first being upper!")]
        public string doctorFirstName { get; set; }

        [Required]
        [Display(Name = "Mid name")]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[А-Я]+[а-я""'\s]*$", ErrorMessage = "Please enter 3 or more characters in Cyrillic, the first being upper!")]
        public string doctorMidName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[А-Я]+[а-я""'\s]*$", ErrorMessage = "Please enter 3 or more characters in Cyrillic, the first being upper!")]
        public string doctorLastName { get; set; }

        [Display(Name = "Internship")]
        public double internship { get; set; }

        [Display(Name = "Speciality")]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[А-я]+[а-я""'\s]*$", ErrorMessage = "Please enter 3 or more characters in Cyrillic!")]
        public string speciality { get; set; }
    }
}
