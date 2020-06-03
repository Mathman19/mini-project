using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSIS20.ViewModel
{
    public class OrganisasiViewModel
    {
        [Key]
        public long id { get; set; }

        public bool is_delete { get; set; }

        public long biodata_id { get; set; }

        [StringLength(100)]
        [Display(Name = "Nama Organisasi*")]
        public string name { get; set; }

        [StringLength(50)]
        [Display(Name = "Jabatan*")]
        public string position { get; set; }

        [StringLength(10)]
        [Display(Name = "Tahun Masuk*")]
        public string entry_year { get; set; }

        [StringLength(10)]
        [Display(Name = "Tahun Keluar*")]
        public string exit_year { get; set; }

        [StringLength(100)]
        [Display(Name = "Tanggung Jawab")]
        public string responsibility { get; set; }

        [StringLength(1000)]
        [Display(Name = "Catatan")]
        public string notes { get; set; }
    }
}
