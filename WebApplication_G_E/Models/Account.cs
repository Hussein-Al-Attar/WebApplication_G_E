

using System.ComponentModel.DataAnnotations;

namespace WebApplication_G_E.Models
{
    public class Account
    {
        [Display(Name ="الاسم الكامل")]
        [Required(ErrorMessage ="حقل الاسم مطلوب")]
        [StringLength (100,MinimumLength =5,ErrorMessage ="msg")]
        public string FullName { get; set; }
       
        
        [Range(18,40)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(11,MinimumLength =11)]
        [RegularExpression("^[0-9]*$")]
        public string Phone { get; set; }


        [Required]
        [StringLength( 10,MinimumLength = 6)]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="غير متطابق")]
        public string ConfirmPassword { get; set; }
        [FileExtensions(Extensions =".jpg,.png,.gif,.jpeg")]
        public string ImageProfile { get; set; }

    }
}
