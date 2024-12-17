using HospitalManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Repository
{
    public  interface IDoctorRepository
    {
        void Add(Doctor doctor);
        Doctor GetById(int id);
        IEnumerable<Doctor> GetAll();
        void Update(Doctor doctor);
        void  Remove(int id);
    }
}
