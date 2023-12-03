namespace Practical_3_Kopylov_Maxim.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("client")]
    public partial class client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public client()
        {
            zakaz = new HashSet<zakaz>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_clienta { get; set; }

        [Required]
        [StringLength(50)]
        public string familia { get; set; }

        [Required]
        [StringLength(50)]
        public string imya { get; set; }

        [Required]
        [StringLength(50)]
        public string otchestvo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal nomer_phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zakaz> zakaz { get; set; }
    }
}
