namespace Practical_3_Kopylov_Maxim.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("avtorization")]
    public partial class avtorization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public avtorization()
        {
            sotrudniki = new HashSet<sotrudniki>();
        }

        [Key]
        public int ID_polyzovatelia { get; set; }

        [Required]
        public string login { get; set; }

        [Required]
        public string paron { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sotrudniki> sotrudniki { get; set; }
    }
}
