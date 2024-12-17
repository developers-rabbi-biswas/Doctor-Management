using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Repository;
using HospitalManagement.Factory;
using HospitalManagement.Model;


namespace HospitalManagement.Record
{
    public class DoctorRecord
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IDoctorFactory _doctorFactory;

        public DoctorRecord(IDoctorRepository doctorRepository, IDoctorFactory doctorFactory)
        {
            _doctorRepository = doctorRepository;
            _doctorFactory = doctorFactory;
        }
        public void AddDoctor(int id, string DoctorName, string Specialist, string Department, DateTime JoiningDate)
        {
            var doctor = _doctorFactory.CreateDoctor(id, DoctorName, Specialist, Department, JoiningDate);
            _doctorRepository.Add(doctor);
        }
        public IEnumerable<Doctor>GetAllDoctors()
        {
            return _doctorRepository.GetAll();
        }
        public Doctor GetById(int id)
        {
            return _doctorRepository.GetById(id);
        }
        public void UpdateDoctor(int id, string DoctorName, string Specialist, string Department, DateTime JoiningDate)
        {
            var doctor = _doctorFactory.UpdateDoctor(id, DoctorName, Specialist, Department, JoiningDate);
            _doctorRepository.Update(doctor);
        }
        public void DeleteDoctor(int id)
        {
            _doctorRepository.Remove(id);
        }


    }
}
