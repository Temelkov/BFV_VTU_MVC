using System.ComponentModel.DataAnnotations;

namespace TESTAPP.Models
{
    public class Doctor
    {
        [Key]
        public int doctor_id { get; set; }

        [Display(Name = "First name")]
        public string doctorFirstName { get; set; }

        [Display(Name = "Mid name")]
        public string doctorMidName { get; set; }

        [Display(Name = "Last name")]
        public string doctorLastName { get; set; }

        [Display(Name = "Internship")]
        public double internship { get; set; }

        [Display(Name = "Speciality")]
        public string speciality { get; set; }
    }
}
