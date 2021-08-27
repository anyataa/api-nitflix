using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        [Required]
        public int MembershipTypeId { get; set; }

        //public virtual MembershipType MembershipType { get; set; }

    }
}
