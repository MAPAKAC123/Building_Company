namespace Practical_3_Kopylov_Maxim.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sotrudniki")]
    public partial class sotrudniki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sotrudniki()
        {
            zakaz = new HashSet<zakaz>();
        }

        [Key]
        public int ID_sotrudnika { get; set; }

        [Required]
        [StringLength(50)]
        public string familia { get; set; }

        [Required]
        [StringLength(50)]
        public string imya { get; set; }

        [StringLength(50)]
        public string otchestvo { get; set; }

        [Required]
        [StringLength(4)]
        public string nomer_passporta { get; set; }

        [Required]
        [StringLength(6)]
        public string seria_passporta { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_priema_na_raboty { get; set; }

        public int ID_polyzovatelia { get; set; }

        public int? ID_doljnosti { get; set; }

        public virtual avtorization avtorization { get; set; }

        public virtual doljnosti doljnosti { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zakaz> zakaz { get; set; }
    }
}
