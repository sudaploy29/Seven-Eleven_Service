﻿using System.ComponentModel.DataAnnotations;

namespace SevenEleven.DTOs
{
      public class UserRegisterDto
      {
            [Required]
            [StringLength(20)]
            public string Username { get; set; }

            [Required]
            [StringLength(20)]
            public string Password { get; set; }
      }
}