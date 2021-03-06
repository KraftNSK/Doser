﻿using System;

namespace Doser.Models
{
    public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Port Port { get; set; }
        public DateTime? TimeCreate { get; set; }
        public DateTime? TimeDeleted { get; set; }
        public User UserCreate { get; set; }
        public User UserDeleted { get; set; }
        public bool isDeleted { get; set; }
        public string Description { get; set; }
    }
}