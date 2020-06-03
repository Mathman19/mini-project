using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSIS20.ViewModel
{
    public class EducationLevelViewModel
    {
        [Key]
        public int id { get; set; }

        public bool is_delete { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(100)]
        public string description { get; set; }
    }
}
