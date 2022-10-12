
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DFA_CRUD.Models
{
    public partial class Product
    {
        [Key]
    
        public int Pid { get; set; }
        [Required(ErrorMessage = "Enter the Product Name")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Name must consist of minimum 4 characters")]
   

        public string? Pname { get; set; }
        [Required(ErrorMessage = "Enter the Product Brand")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Brand must consist of minimum 4 characters")]
       
        public string? Pbrand { get; set; }
        [Required(ErrorMessage = "Enter the Product Description")]
        /*[StringLength(15, MinimumLength = 4, ErrorMessage = "Description must consist of minimum 4 characters")]*/
        [MaxLength(20,ErrorMessage = "Oops You cannot Enter More !!!")]

        public string? Pdescription { get; set; }

        [DisplayName("Price")]
        public int? Price { get; set; }
    }
}
