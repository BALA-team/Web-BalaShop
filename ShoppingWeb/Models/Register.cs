using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingWeb.Models
{
    public class Register
    {
        public Guid clientId { get; set; }
        [Required(ErrorMessage = "Login jest wymagany")]
        [Remote("IsLoginAlredyExist", "Home", HttpMethod = "POST", ErrorMessage = "Podany login juz jest zajęty")]
        public string login { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "E-mail jest wymagany")]
        [EmailAddress(ErrorMessage = "Nie poprawny adres e-mail")]
        [Remote("IsEmailAlredyExist", "Home", HttpMethod = "POST", ErrorMessage = "Podany e-mail juz jest zajęty")]
        public string email { get; set; }
    }
}