using System;

namespace IDoser.Models
{
    public class Terminal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Line Line { get; set; }
        public Port ComPort { get; set; }
        public int Address485 { get; set; }
        public string IPAddress { get; set; }
        public double EmptyWeigth { get; set; }
        public DateTime TimeCreate { get; set; }
        public DateTime TimeDeleted { get; set; }
        public User UserCreate { get; set; }
        public User UserDeleted { get; set; }
        public bool isDeleted { get; set; }
        public string Description { get; set; }
    }
}