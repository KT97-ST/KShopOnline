namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        public int account_id { get; set; }

        [Required]
        [StringLength(200)]
        public string account_username { get; set; }

        [Required]
        [StringLength(200)]
        public string account_password { get; set; }
    }
}
