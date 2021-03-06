﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileApi.WebApi.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int GenderId { get; set; }
        public DateTime TimeCreated { get; set; }

        public Gender Gender { get; set; }
    }
}
