using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Model;

namespace HospitalManagement.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly List<Doctor> _doctors = new List<Doctor>();
        public void Add(Doctor doctor)
        {
            _doctors.Add(doctor);
        }
        public Doctor GetById(int id)
        {
            return _doctors.FirstOrDefault(d => d.Id == id);
        }
        public IEnumerable<Doctor> GetAll()
        {
        return _doctors; 
        }
        public void Update(Doctor doctor)
        {
            var _doctor = _doctors.FirstOrDefault( d => d.Id == doctor.Id);
            if (_doctor != null)
            {
                _doctor.DoctorName = doctor.DoctorName;
                _doctor.Specialist = doctor.Specialist;
                _doctor.Specialist = doctor.Specialist;
                _doctor.Department = doctor.Department;
                _doctor.JoiningDate = doctor.JoiningDate;
            }
        }
        public void Remove(int id)
        {
            var _doctor = _doctors.FirstOrDefault(d => d.Id == d.Id);
            if (_doctor != null)
            {
                _doctors.Remove(_doctor);
            }
        }

    }
}
