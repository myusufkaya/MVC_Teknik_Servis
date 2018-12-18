namespace TeknikServis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tedarik")]
    public partial class Tedarik
    {
        [Key]
        public int Tedarik_ID { get; set; }

        public int Malzeme_ID { get; set; }

        public int Tedarik_Adet { get; set; }

        public DateTime Siparis_Tarih { get; set; }

        public double Fiyat { get; set; }

        public virtual Malzeme Malzeme { get; set; }
    }
}
