﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SerasGida.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez"), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}