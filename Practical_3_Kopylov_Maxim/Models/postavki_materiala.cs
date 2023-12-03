namespace Practical_3_Kopylov_Maxim.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class postavki_materiala
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_postavki_materiala { get; set; }

        public int ID_material { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_dostavki { get; set; }

        [Required]
        [StringLength(50)]
        public string kolichestvo_materiala { get; set; }

        public int ID_objekta { get; set; }

        public virtual material material { get; set; }

        public virtual objekt objekt { get; set; }
    }
}
