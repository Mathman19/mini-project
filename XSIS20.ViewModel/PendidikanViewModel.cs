using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSIS20.ViewModel
{
    public class PendidikanViewModel
    {
        [Key]
        public long id { get; set; }

        public bool is_delete { get; set; }

        public long biodata_id { get; set; }

        [Display(Name ="Sekolah/Instansi*")]
        [StringLength(100)]
        public string school_name { get; set; }

        [Display(Name = "Kota")]
        [StringLength(50)]
        public string city { get; set; }

        [Display(Name = "Negara")]
        [StringLength(50)]
        public string country { get; set; }

        [Display(Name ="Jenjang Pendidikan*")]
        public int education_level_id { get; set; }

        [Display(Name = "Jenjang Pendidikan")]
        public string EducationName { get; set; }

        [Display(Name = "Tahun Masuk")]
        [StringLength(10)]
        public string entry_year { get; set; }

        [Display(Name = "Tahun Lulus")]
        [StringLength(10)]
        public string graduation_year { get; set; }

        [Display(Name = "Jurusan")]
        [StringLength(100)]
        public string major { get; set; }

        [Display(Name ="IPK")]
        public decimal gpa { get; set; }

        [Display(Name = "Catatan")]
        [StringLength(1000)]
        public string notes { get; set; }
    }
}
