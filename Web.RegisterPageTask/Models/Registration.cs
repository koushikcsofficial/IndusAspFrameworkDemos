namespace Web.RegisterPageTask.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Registration
    {
        [Key]
        public int Account_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Account_Email { get; set; }

        [Required]
        public string Account_Password { get; set; }
    }
}
