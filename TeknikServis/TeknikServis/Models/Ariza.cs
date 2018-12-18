namespace TeknikServis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ariza")]
    public partial class Ariza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ariza()
        {
            Onarims = new HashSet<Onarim>();
        }

        [Key]
        public int Ariza_ID { get; set; }

        public int Tip_ID { get; set; }

        public DateTime Tarih { get; set; }

        public int Mus_ID { get; set; }

        [Required]
        [StringLength(500)]
        public string Detay { get; set; }

        public bool Durum { get; set; }

        [Required]
        [StringLength(50)]
        public string Urun_Ad { get; set; }

        [Required]
        [StringLength(50)]
        public string Urun_Kategori { get; set; }

        public virtual Ariza_Tip Ariza_Tip { get; set; }

        public virtual Musteri Musteri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Onarim> Onarims { get; set; }
    }
}
