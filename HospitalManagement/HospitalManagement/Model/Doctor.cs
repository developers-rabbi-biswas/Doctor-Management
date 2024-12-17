using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace HospitalManagement.Model
{
    public class Doctor
    {
        public int Id { get; set; }
        public string DoctorName { get; set; }
        public string Specialist { get; set; }
        public string Department { get; set; }
        public DateTime JoiningDate { get; set; }
        public Doctor(int id, string doctorName, string specialist, string department, DateTime joiningDate)
        {
            Id = id;
            DoctorName = doctorName;
            Specialist = specialist;
            Department = department;
            JoiningDate = joiningDate;

        }
    }
}
