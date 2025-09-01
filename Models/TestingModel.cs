using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kylan.space.Models
{
    public class TestingModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Input is Required.")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Input is Required.")]
        public string lastName { get; set; }
        [Required]
        public string captcha { get; set; }
        [Required(ErrorMessage = "Captcha is required.")]
        [Compare("captcha", ErrorMessage = "Captcha is incorrect.")]
        public string captchaResponse { get; set; }
    }
}