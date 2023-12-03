namespace Practical_3_Kopylov_Maxim.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("material")]
    public partial class material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public material()
        {
            postavki_materiala = new HashSet<postavki_materiala>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_material { get; set; }

        [Required]
        [StringLength(50)]
        public string nazvanie_materiala { get; set; }

        public double kolichestvo_materiala { get; set; }

        public int? chena { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<postavki_materiala> postavki_materiala { get; set; }
    }
}
