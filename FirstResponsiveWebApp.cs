using System;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppLastName.Models
{
    public class UserModel
    {
        
        public const int CURRENT_YEAR = 2026;

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Birth year is required.")]
        [Range(1900, CURRENT_YEAR, ErrorMessage = "Birth year must be between 1900 and current year.")]
        public int BirthYear { get; set; }

        public int AgeThisYear()
        {
            return CURRENT_YEAR - BirthYear;
        }
    }
}


