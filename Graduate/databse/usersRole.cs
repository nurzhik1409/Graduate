namespace Graduate.databse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usersRole")]
    public partial class usersRole
    {
        public int id { get; set; }

        public int? idUser { get; set; }

        public int? idRole { get; set; }

        public virtual role role { get; set; }

        public virtual users users { get; set; }
    }
}
