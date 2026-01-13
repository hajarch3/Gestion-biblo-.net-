using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GESTION_BIBLIO.Models
{

    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(1000)]
        public string Biography { get; set; }

        // Relation avec Book
        public virtual ICollection<Book> Books { get; set; }
    }
}