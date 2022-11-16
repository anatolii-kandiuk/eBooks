using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace eBooks.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [DisplayName("Display Oreder")]
        [Range(1, 100, ErrorMessage ="Display Order must be between 1 and 100 only")]
        public int DisplayOrder { get; set; }
        
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}