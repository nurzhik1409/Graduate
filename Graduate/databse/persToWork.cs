namespace Graduate.databse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("persToWork")]
    public partial class persToWork
    {
        public int id { get; set; }

        public int? idPers { get; set; }

        public int? idFreeWork { get; set; }

        [StringLength(500)]
        public string nameStateOrg { get; set; }

        [StringLength(500)]
        public string nameOrg { get; set; }

        [StringLength(500)]
        public string post { get; set; }

        [StringLength(50)]
        public string numCertificate { get; set; }

        [StringLength(50)]
        public string numReference { get; set; }

        [StringLength(1)]
        public string verificationArrival { get; set; }

        [StringLength(500)]
        public string commentary { get; set; }

        public DateTime? dateCrt { get; set; }

        [StringLength(500)]
        public string educational { get; set; }

        [StringLength(50)]
        public string cityOrg { get; set; }

        public virtual freeWork freeWork { get; set; }

        public virtual persons persons { get; set; }
    }
}
