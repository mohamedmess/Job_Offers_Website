using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Job_Offers_Website.Models
{
    public class Job
    {
        public int Id { get; set; }

        [DisplayName("Job Name")]
        public string JobTitle { get; set; }

        [DisplayName("Job Description")]
        public string JobContent { get; set; }

        [DisplayName("Image of Job")]
        public string JobImage { get; set; }

        /*CategoryId = foreign key from Category Table*/
        [DisplayName("Job Category")]
        public int CategoryId { get; set; }

        /*un Job appartient à une catégorie, on ajoute 'virtual' pour activer Lasy Loading
         voir: https://www.c-sharpcorner.com/article/lazy-loading-in-asp-net-mvc/ */
        public virtual Category Category { get; set; }

    }
}