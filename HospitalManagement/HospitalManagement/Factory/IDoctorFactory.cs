using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Model;

namespace HospitalManagement.Factory
{
    public interface IDoctorFactory
    {
        Doctor CreateDoctor(int id, string DoctorName, string Specialist, string Department, DateTime JoiningDate);
        Doctor UpdateDoctor(int id, string DoctorName, string Specialist, string Department, DateTime JoiningDate);
    }
}
