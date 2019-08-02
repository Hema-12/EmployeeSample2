using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeApp.Models
{
    public class Emp
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Enter Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Enter EmailID")]
        public string EmailID { get; set; }

        [Required(ErrorMessage = "Enter Postal Code")]
        public string PostalCode { get; set; }

        public bool Retired { get; set; }

        [Required(ErrorMessage = "Enter State")]
        public string StateName { get; set; }
    }
}