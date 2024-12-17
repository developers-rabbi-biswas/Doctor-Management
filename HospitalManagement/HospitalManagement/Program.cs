using HospitalManagement.Factory;
using HospitalManagement.Model;
using HospitalManagement.Record;
using HospitalManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDoctorRepository doctorRepository = new DoctorRepository();
            IDoctorFactory doctorFactory = new DoctorFactory();
            DoctorRecord doctorRecord = new DoctorRecord(doctorRepository, doctorFactory);
            AddCommands();
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    var command = Console.ReadLine().ToLower();
                    if (command == "y")
                    {
                        Console.Clear();
                        AddCommands();
                    }
                    else if (command == "x")
                    {
                        isRunning = false;
                    }
                    else if(command == "r")
                        {
                        Console.WriteLine("Type 'a' All Record for Doctor");
                        command = Console.ReadLine();
                        if(command == "a")
                        {
                            Console.WriteLine("Type a Doctor ID");
                            var id = Convert.ToInt32(Console.ReadLine());
                            var doctor = doctorRecord.GetById(id);
                            if (doctor != null)
                            {
                                Console.WriteLine($"{doctor.DoctorName}:{doctor.Specialist}:{doctor.Department}:{doctor.JoiningDate}");
                            }
                            else
                            {
                                Console.WriteLine("Doctor Not Found");
                            }
                        }
                        else if (command == "all")
                        {
                            //Read and Display Doctor Information
                            Console.WriteLine("Please Check the Detsils");
                            foreach(var doctor in doctorRecord.GetAllDoctors())
                            {
                                Console.WriteLine($"{doctor.DoctorName}:{doctor.Specialist}:{doctor.Department}:{doctor.JoiningDate}");
                            }

                        }
                        else
                        {
                            Console.WriteLine("'" + command + "'" + " is not a valid command.");
                        }

                    }
                    else if(command == "c")
                    {
                        Console.WriteLine("Please Enter the Doctor ID");
                        var id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please Enter the Name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Please Enter the Doctor Specialist");
                        var specialist = Console.ReadLine();
                        Console.WriteLine("Please Enter the Department");
                        var department = Console.ReadLine();
                        Console.WriteLine("Please Enter the Joining Date");
                        var joiningDate =Convert.ToDateTime(Console.ReadLine());
                        //Create a new Doctor Record
                        doctorRecord.AddDoctor(id, name, specialist, department, joiningDate);
                        Console.WriteLine("'" + name + "' as Doctor Record, created successfully.");
                    }
                    else if(command == "u")
                    {
                        Console.WriteLine("Enter the Doctor ID");
                        var id = Convert.ToInt32(Console.ReadLine());
                        var doctor = doctorRecord.GetById(id);
                        if (doctor != null)
                        {
                            Console.WriteLine("Please Check the Record");
                            Console.WriteLine($"{doctor.DoctorName}:{doctor.Specialist}:{doctor.Department}:{doctor.JoiningDate}");
                            Console.WriteLine("Enter the Doctor Name");
                            var name = Console.ReadLine();
                            Console.WriteLine("Enter the Specialis");
                            var specialist = Console.ReadLine();
                            Console.WriteLine("Enter the Department");
                            var department = Console.ReadLine();
                            Console.WriteLine("Enter the Joining Date");
                            var joiningDate = Convert.ToDateTime(Console.ReadLine());
                            doctorRecord.UpdateDoctor(id, name, specialist, department, joiningDate);
                            Console.WriteLine("'" + name + "' as Doctor Record, Update successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Record not Found.");
                        }
                    }
                    else if (command == "d")
                    {
                        Console.WriteLine("Enter the Doctor ID");
                        var id = Convert.ToInt32(Console.ReadLine());
                        var doctor = doctorRecord.GetById(id);
                        if (doctor != null)
                        {
                            Console.WriteLine("Check the Record");
                            Console.WriteLine($"{doctor.DoctorName}:{doctor.Specialist}:{doctor.Department}:{doctor.JoiningDate}");
                            //Confirm Delete
                            doctorRecord.DeleteDoctor(id);
                            Console.WriteLine("'" + doctor.DoctorName + "' as Doctor Record, deletd successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Record not Found");
                        }
                    }
                    else
                    {
                        Console.WriteLine("'" + command + "'" + " is not a valid command.");
                    }
                }
                catch { }
            }
        }
        static void AddCommands()
        {
            Console.WriteLine("Enter 'C' for creation of Doctor record");
            Console.WriteLine("Enter 'R' for read a record");
            Console.WriteLine("Enter 'U' for update of record");
            Console.WriteLine("Enter 'D' for deletion of record");
            Console.WriteLine("Enter 'Y' for clear window and 'X' for exit");
            Console.WriteLine("-------------------------------------------");
        }
    }
}
