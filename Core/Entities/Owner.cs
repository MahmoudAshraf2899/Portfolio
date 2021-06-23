﻿using System;

namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public String FullName { get; set; }
        public string Profile { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }
    }
}
