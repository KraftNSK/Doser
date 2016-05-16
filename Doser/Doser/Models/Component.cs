using System;

namespace IDoser.Models
{
    public class Component
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Terminal Terminal { get; set; }
        public Bunker Bunker { get; set; }
        public Material Material { get; set; }
        public Port Port { get; set; }
        public bool UseImpMode { get; set; }
        public double TargetWeigth { get; set; }
        public double ResultWeigth { get; set; }
        public double ProductVolume{ get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeFinished { get; set; }
        public int Status { get; set; }
    }
}