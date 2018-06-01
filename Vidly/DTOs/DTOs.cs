using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class CustomerDTOs
    {

        public int Id { get; set; }

        [Required ]
        [StringLength(255)]
        public String Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

                 
        public byte MembershipTypeId { get; set; }


         
        //[Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }
    }
}