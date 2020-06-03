namespace XSIS20.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class x_employee_leave
    {
        public long id { get; set; }

        [Required]
        [StringLength(11)]
        public string created_by { get; set; }

        public DateTime created_on { get; set; }

        [StringLength(11)]
        public string modified_by { get; set; }

        public DateTime? modified_on { get; set; }

        [StringLength(11)]
        public string deleted_by { get; set; }

        public DateTime? deleted_on { get; set; }

        public bool is_delete { get; set; }

        public long employee_id { get; set; }

        public int regular_quota { get; set; }

        public int annual_collective_leave { get; set; }

        public int leave_already_taken { get; set; }
    }
}
