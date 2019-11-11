namespace Graduate.databse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logs
    {
        public int id { get; set; }

        public int? idUser { get; set; }

        [StringLength(10)]
        public string typeSql { get; set; }

        [StringLength(100)]
        public string nameTable { get; set; }

        [StringLength(100)]
        public string fielTable { get; set; }

        [StringLength(1500)]
        public string oldValue { get; set; }

        [StringLength(1500)]
        public string newValue { get; set; }

        public DateTime? dateCrt { get; set; }

        public virtual users users { get; set; }
    }
}
