using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSIS20.DataModel;
using XSIS20.ViewModel;

namespace XSIS20.DataAccess
{
    public class PendidikanRepo
    {
        // GET ALL
        public static List<PendidikanViewModel> All()
        {
            List<PendidikanViewModel> result = new List<PendidikanViewModel>();
            using (var db = new XSIS20Context())
            {
                result = db.x_riwayat_pendidikan
                    .Where(p => p.is_delete == false)
                    .Select(p => new PendidikanViewModel
                    {
                        id = p.id,
                        biodata_id = p.biodata_id,
                        school_name = p.school_name,
                        city = p.city,
                        country = p.country,
                        education_level_id = p.education_level_id,
                        EducationName = p.x_education_level.name,
                        entry_year = p.entry_year,
                        graduation_year = p.graduation_year,
                        major = p.major,
                        gpa = p.gpa,
                        notes = p.notes
                    }).ToList();
            }
            return result;
        }

        public static PendidikanViewModel ById(long id)
        {
            PendidikanViewModel result = new PendidikanViewModel();
            using (var db = new XSIS20Context())
            {
                result = db.x_riwayat_pendidikan
                    .Where(p => p.is_delete == false && p.id == id)
                    .Select(p => new PendidikanViewModel
                    {
                        id = p.id,
                        biodata_id = p.biodata_id,
                        school_name = p.school_name,
                        city = p.city,
                        country = p.country,
                        education_level_id = p.education_level_id,
                        EducationName = p.x_education_level.name,
                        entry_year = p.entry_year,
                        graduation_year = p.graduation_year,
                        major = p.major,
                        gpa = p.gpa,
                        notes = p.notes
                    }).FirstOrDefault();
                if (result == null)
                {
                    result = new PendidikanViewModel();
                }
                return result;
            }
        }

        public static List<PendidikanViewModel> ByEducation(int id)
        {
            List<PendidikanViewModel> result = new List<PendidikanViewModel>();
            using (var db = new XSIS20Context())
            {
                result = db.x_riwayat_pendidikan
                    .Where(p => p.is_delete == false && p.education_level_id == id)
                    .Select(p => new PendidikanViewModel
                    {
                        id = p.id,
                        biodata_id = p.biodata_id,
                        school_name = p.school_name,
                        city = p.city,
                        country = p.country,
                        education_level_id = p.education_level_id,
                        EducationName = p.x_education_level.name,
                        entry_year = p.entry_year,
                        graduation_year = p.graduation_year,
                        major = p.major,
                        gpa = p.gpa,
                        notes = p.notes
                    }).ToList();
            }
            return result;
        }

        // UPDATE
        public static ResponseResult Update(PendidikanViewModel entity)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new XSIS20Context())
                {
                    // CREATE
                    if (entity.id == 0)
                    {
                        x_riwayat_pendidikan pend = new x_riwayat_pendidikan();
                        pend.school_name = entity.school_name;
                        pend.city = entity.city;
                        pend.country = entity.country;
                        pend.education_level_id = entity.education_level_id;
                        pend.entry_year = entity.entry_year;
                        pend.graduation_year = entity.graduation_year;
                        pend.major = entity.major;
                        pend.gpa = entity.gpa;
                        pend.notes = entity.notes;

                        pend.created_by = "Akbar";
                        pend.created_on = DateTime.Now;

                        db.x_riwayat_pendidikan.Add(pend);
                        db.SaveChanges();

                        result.Entity = pend;
                    }
                    // EDIT
                    else
                    {
                        x_riwayat_pendidikan pend = db.x_riwayat_pendidikan.Where(p => p.is_delete==false && p.id == entity.id).FirstOrDefault();
                        if (pend != null)
                        {
                            pend.school_name = entity.school_name;
                            pend.city = entity.city;
                            pend.country = entity.country;
                            pend.education_level_id = entity.education_level_id;
                            pend.entry_year = entity.entry_year;
                            pend.graduation_year = entity.graduation_year;
                            pend.major = entity.major;
                            pend.gpa = entity.gpa;
                            pend.notes = entity.notes;

                            pend.modified_by = "Akbar";
                            pend.modified_on = DateTime.Now;

                            db.SaveChanges();

                            result.Entity = entity;
                        }
                        else
                        {
                            result.Success = false;
                            result.Message = "Pendidikan Not Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public static ResponseResult Delete(long id)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new XSIS20Context())
                {
                    x_riwayat_pendidikan pend = db.x_riwayat_pendidikan.Where(p => p.is_delete == false && p.id == id).FirstOrDefault();
                    if (pend != null)
                    {
                        pend.is_delete = true;
                        PendidikanViewModel entity = new PendidikanViewModel();
                        entity.id = pend.id;
                        entity.is_delete = pend.is_delete;
                        entity.biodata_id = pend.biodata_id;
                        entity.school_name = pend.school_name;
                        entity.city = pend.city;
                        entity.country = pend.country;
                        entity.education_level_id = pend.education_level_id;
                        entity.EducationName = pend.x_education_level.name;
                        entity.entry_year = pend.entry_year;
                        entity.graduation_year = pend.graduation_year;
                        entity.major = pend.major;
                        entity.gpa = pend.gpa;
                        entity.notes = pend.notes;

                        db.SaveChanges();

                        pend.deleted_by = "Akbar";
                        pend.deleted_on = DateTime.Now;

                        result.Entity = entity;
                    }
                    else
                    {
                        result.Success = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
