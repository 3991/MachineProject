using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MachineProject.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Compte n°")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "Prénom")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Nom")]
        public string LastName { get; set; }

       
        /*public string Name { get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }*/

        [Display(Name = "Meilleur résultat (secondes)")]
        public decimal Result { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ICollection<ResultOperation> ResultOperations { get; set; }

    }
}