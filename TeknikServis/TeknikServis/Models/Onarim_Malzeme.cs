namespace TeknikServis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Onarim_Malzeme
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Onarim_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Malzeme_ID { get; set; }

       // public double Fiyat { get; set; }

        public virtual Malzeme Malzeme { get; set; }

        public virtual Onarim Onarim { get; set; }
    }
}
