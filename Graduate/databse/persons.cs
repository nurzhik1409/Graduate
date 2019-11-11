namespace Graduate.databse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class persons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public persons()
        {
            persToWork = new HashSet<persToWork>();
        }

        public int id { get; set; }

        public int? idTypeQualification { get; set; }

        [StringLength(50)]
        public string surname { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string patronymic { get; set; }

        [StringLength(3)]
        public string gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        [StringLength(50)]
        public string addressCountry { get; set; }

        [StringLength(50)]
        public string addressRegion { get; set; }

        [StringLength(50)]
        public string addressArea { get; set; }

        [StringLength(50)]
        public string addressCity { get; set; }

        [StringLength(50)]
        public string addressStreet { get; set; }

        [StringLength(20)]
        public string addressHome { get; set; }

        [StringLength(20)]
        public string addressFlat { get; set; }

        [StringLength(500)]
        public string trainingDirection { get; set; }

        [StringLength(500)]
        public string profile { get; set; }

        public short? yeatIssue { get; set; }

        public virtual typeQualification typeQualification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<persToWork> persToWork { get; set; }
    }
}
