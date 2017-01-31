using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MachineProject.Models
{
    public class Player
    {
        [Key, ForeignKey("Plane")]
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Plane Plane { get; set; }
    }
}