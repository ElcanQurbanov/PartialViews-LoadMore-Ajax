﻿namespace FrontToBack.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDelete { get; set; } = false;
    }
}
