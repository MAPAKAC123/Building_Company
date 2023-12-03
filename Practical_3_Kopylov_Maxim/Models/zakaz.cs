namespace Practical_3_Kopylov_Maxim.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zakaz")]
    public partial class zakaz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zakaz()
        {
            dop_yslyga = new HashSet<dop_yslyga>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_zakaza { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_zakaza { get; set; }

        [Required]
        [StringLength(50)]
        public string status_zakaza { get; set; }

        public int ID_clienta { get; set; }

        public int ID_objekta { get; set; }

        public int ID_sotrudnika { get; set; }

        public virtual client client { get; set; }

        public virtual objekt objekt { get; set; }

        public virtual sotrudniki sotrudniki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dop_yslyga> dop_yslyga { get; set; }
    }
}
