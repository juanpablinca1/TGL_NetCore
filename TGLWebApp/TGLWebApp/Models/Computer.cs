using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TGLWebApp.Models
{
    public class Computer
    {
        

        public Computer()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Cpu { get; set; }
        public double Ram { get; set; }

    }
}
