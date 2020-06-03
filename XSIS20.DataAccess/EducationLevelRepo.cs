using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSIS20.DataModel;
using XSIS20.ViewModel;

namespace XSIS20.DataAccess
{
    public class EducationLevelRepo
    {
        public static List<EducationLevelViewModel> All()
        {
            List<EducationLevelViewModel> result = new List<EducationLevelViewModel>();
            using (var db = new XSIS20Context())
            {
                result = db.x_education_level
                    .Where(e => e.is_delete == false)
                    .Select(e => new EducationLevelViewModel
                    {
                        id = e.id,
                        name = e.name,
                        description = e.description
                    }).ToList();
            }
            return result;
        }
    }
}
