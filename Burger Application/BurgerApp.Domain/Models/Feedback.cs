﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.Domain.Models
{
    public class Feedback : BaseEntity
    {
        public string  Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
