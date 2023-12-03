namespace Practical_3_Kopylov_Maxim.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("itap-objekt")]
    public partial class itap_objekt
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_itap { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_objekta { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_nachala { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_koncha { get; set; }

        [Column(TypeName = "date")]
        public DateTime itogovai_data { get; set; }

        public virtual itap_stroitelistva itap_stroitelistva { get; set; }

        public virtual objekt objekt { get; set; }
    }
}
