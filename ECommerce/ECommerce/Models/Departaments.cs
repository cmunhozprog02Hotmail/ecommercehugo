﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Departaments
    {
        [Key]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage="O Campo Nome é requerido!")]
        public string Name { get; set; }
    }
}