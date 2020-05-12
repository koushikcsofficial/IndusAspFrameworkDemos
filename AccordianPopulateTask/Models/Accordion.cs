namespace AccordianPopulateTask.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Accordion
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Accordion_HeadLine { get; set; }

        [Required]
        public string Accordion_Description { get; set; }
    }
}
