using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.User
{
    public class UserUpdateDto
    {
        [Required(ErrorMessage = "必填")]
        [StringLength(60, ErrorMessage = "長度過長，不得多於{1}長度。")]
        public string Id { get; set; }


        [Required(ErrorMessage = "必填")]
        [StringLength(60, ErrorMessage = "長度過長，不得多於{1}長度。")]
        public string Name { get; set; }

        [Required(ErrorMessage = "必填")]
        [EmailAddress(ErrorMessage = "請填寫正確的電子郵件")]
        [StringLength(100, ErrorMessage = "長度過長，不得多於{1}長度。")]
        public string Email { get; set; }
    }
}
