using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSIS20.DataModel
{
    public partial class x_education_level
    {
        [Key]
        public int id { get; set; }

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

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public virtual ICollection<x_riwayat_pendidikan> x_riwayat_pendidikan { get; set; }
    }
}
