using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // pour pouvoir utiliser [Required] et [autres]
using System.Linq;
using System.Web;

namespace Job_Offers_Website.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Job Category")]
        public string CategoryName { get; set; }

        [Required]
        [Display(Name ="Description of Category")]
        public string CategoryDescription { get; set; }

        /*une seule catégorie peut comporter plusieurs Jobs || on ajoute 'virtual' pour activer Lazy Loading*/
        public virtual ICollection<Job> Jobs { get; set; }
    }
}