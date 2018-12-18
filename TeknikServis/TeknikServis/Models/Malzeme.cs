namespace TeknikServis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Malzeme")]
    public partial class Malzeme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Malzeme()
        {
            Onarim_Malzeme = new HashSet<Onarim_Malzeme>();
            Tedariks = new HashSet<Tedarik>();
        }

        [Key]
        public int Malzeme_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Malzeme_Ad { get; set; }

        public int Adet { get; set; }

        public double Fiyat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Onarim_Malzeme> Onarim_Malzeme { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tedarik> Tedariks { get; set; }
    }
}
