using HospitalManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Factory
{
    public class DoctorFactory: IDoctorFactory
    {
        public Doctor CreateDoctor(int id, string DoctorName, string Specialist, string Department, DateTime JoiningDate)
            {
            return new Doctor( id, DoctorName, Specialist, Department, JoiningDate);

        }
        public Doctor UpdateDoctor(int id, string DoctorName, string Specialist, string Department, DateTime JoiningDate)
            {
            return new Doctor(id, DoctorName, Specialist, Department, JoiningDate);
        }
    }
}
