using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GESTION_BIBLIO.Models
{


    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(20)]
        public string Role { get; set; }
        // Student | Admin | Librarian

        [Required]
        [StringLength(20)]
        public string CIN { get; set; }   

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [StringLength(150)]
        public string Address { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public bool IsActive { get; set; }
    }
}