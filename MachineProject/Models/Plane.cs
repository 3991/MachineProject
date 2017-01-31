using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MachineProject.Models
{
    public class Plane
    {

        [Key, ForeignKey("Player")]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Player_ID { get; set; }
        public virtual Player Player { get; set; }
        
    }
}