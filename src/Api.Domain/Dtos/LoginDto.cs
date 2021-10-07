using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage ="必填")]
        [EmailAddress(ErrorMessage ="請填寫正確的電子郵件")]
        [StringLength(100,ErrorMessage ="長度過長，不得多於{1}長度。")]
        public string Email { get; set; }
    }
}
