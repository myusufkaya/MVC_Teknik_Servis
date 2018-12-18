namespace TeknikServis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Onarim")]
    public partial class Onarim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Onarim()
        {
            Onarim_Malzeme = new HashSet<Onarim_Malzeme>();
        }

        [Key]
        public int Onarim_ID { get; set; }

        public int Ariza_ID { get; set; }

        [Required]
        [StringLength(500)]
        public string Islem { get; set; }

        public double Ucret { get; set; }

        public virtual Ariza Ariza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Onarim_Malzeme> Onarim_Malzeme { get; set; }
    }
}
