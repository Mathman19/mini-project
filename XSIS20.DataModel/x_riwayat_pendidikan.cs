namespace XSIS20.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class x_riwayat_pendidikan
    {
        [Key]
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

        public long biodata_id { get; set; }

        [StringLength(100)]
        public string school_name { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(50)]
        public string country { get; set; }

        public int education_level_id { get; set; }

        [StringLength(10)]
        public string entry_year { get; set; }

        [StringLength(10)]
        public string graduation_year { get; set; }

        [StringLength(100)]
        public string major { get; set; }

        public decimal gpa { get; set; }

        [StringLength(1000)]
        public string notes { get; set; }

        public int? order { get; set; }

        [StringLength(225)]
        public string judul_ta { get; set; }

        [StringLength(5000)]
        public string deskripsi_ta { get; set; }

        public virtual x_education_level x_education_level { get; set; }
    }
}
