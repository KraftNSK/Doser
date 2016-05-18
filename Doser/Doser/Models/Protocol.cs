using System;
using System.Collections.Generic;

namespace Doser.Models
{
    public class Protocol
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Line Line { get; set; }
        public Consumer Consumer { get; set; }
        public Product Product { get; set; }
        public List<Component> Components { get; set; }
        public bool UseManual { get; set; }
        public double TargetWeigth { get; set; }
        public double ResultWeigth { get; set; }
        public double ProductVolume { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeFinished { get; set; }
        public int Status { get; set; }
    }
}