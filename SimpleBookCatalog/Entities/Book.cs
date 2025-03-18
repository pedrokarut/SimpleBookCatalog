using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBookCatalog.Entities.Enums;

namespace SimpleBookCatalog.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please provide a title")]
        [MaxLength(100)]
        public string? Title { get; set; }

        [Required(ErrorMessage ="Please provide an Author's name")]
        [MaxLength(100)]
        public string? Autor { get; set; }

        public DateTime? PublicationDate { get; set; }

        [EnumDataType(typeof(Category), ErrorMessage ="Please select a category")]
        public Category Category { get; set; }
    }
}
