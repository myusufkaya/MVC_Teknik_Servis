namespace TeknikServis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [Key]
        public int Kullanici_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Kullanici_Adi { get; set; }

        [Required]
        [StringLength(10)]
        public string Sifre { get; set; }
    }
}
