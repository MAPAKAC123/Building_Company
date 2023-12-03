namespace Practical_3_Kopylov_Maxim.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("objekt")]
    public partial class objekt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public objekt()
        {
            itap_objekt = new HashSet<itap_objekt>();
            postavki_materiala = new HashSet<postavki_materiala>();
            zakaz = new HashSet<zakaz>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_objekta { get; set; }

        [Required]
        [StringLength(50)]
        public string address_objekta { get; set; }

        [Required]
        [StringLength(50)]
        public string ploshad_objekta { get; set; }

        [Required]
        [StringLength(50)]
        public string dlina { get; set; }

        [Required]
        [StringLength(50)]
        public string shirina { get; set; }

        [Required]
        [StringLength(50)]
        public string visota { get; set; }

        public int kol_itzhei { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itap_objekt> itap_objekt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<postavki_materiala> postavki_materiala { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zakaz> zakaz { get; set; }
    }
}
