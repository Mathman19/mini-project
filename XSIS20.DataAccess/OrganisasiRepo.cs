using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSIS20.DataModel;
using XSIS20.ViewModel;

namespace XSIS20.DataAccess
{
    public class OrganisasiRepo
    {
        // Get All
        public static List<OrganisasiViewModel> All()
        {
            List<OrganisasiViewModel> result = new List<OrganisasiViewModel>();
            using (var db = new XSIS20Context())
            {
                result = db.x_organisasi
                    .Where(o => o.is_delete == false)
                    .Select(o => new OrganisasiViewModel
                {
                        id = o.id,
                        biodata_id = o.biodata_id,
                        name = o.name,
                        position = o.position,
                        entry_year = o.entry_year,
                        exit_year = o.exit_year,
                        responsibility = o.responsibility,
                        notes = o.notes
                }).ToList();
            }
            return result;
        }
    }
}
