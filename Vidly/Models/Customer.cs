using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]                          // Gi koristime ovie anotacii za da gi overridneme defaultnite vrednosti na Entity Frameworkot
        [StringLength(255)]     // Gi koristime ovie anotacii za da gi overridneme defaultnite vrednosti na Entity Frameworko
        public string Name { get; set; }
        [Display(Name = "Date of Birth")]
        [Min18YearsIfMember]
        public DateTime? Birthday { get; set; }

        //public List<Customer> Customers { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; } // Dali e pretplaten da dobiva izvestuvanje po mail (da/ne)
        public MembershipType MembershipType { get; set; } // So ova prop gi povrzuvame Customer i MembershipType (instancirame objekt t.e. navigation property)
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } // Nadvoreshen kluch (fk) koga ne ni treba celiot objekt so site negovi objekti.
    }
}