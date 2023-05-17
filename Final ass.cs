using System;
using System.Collections.Generic;

namespace HospitalRegistration
{
    class Patient
    {
        public int RegistrationID { get; set; }
        public int AadharNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNo { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
       
        public string Speciality { get; set; }
    }

    class Program
    {
        static List<Patient> patients = new List<Patient>();
        static object patient;

        static void Main()
        {
        
            while (true)
            {
                Console.WriteLine("1. Register new patient");
                Console.WriteLine("2. Display specific patient details");
                Console.WriteLine("3. Display all patient details");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice (1-4):");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        RegisterNewPatient();
                        break;
                    case 2:
                        DisplaySpecificPatientDetails();
                        break;
                    case 3:
                        DisplayPatientDetails();
                       
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void DisplayPatientDetails()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No patient data available.");
                return;
            }

            foreach (var patient in patients)
            {
              
                Console.WriteLine("Registration ID: " + patient.RegistrationID);
                Console.WriteLine("First Name: " + patient.FirstName);
                Console.WriteLine("Last Name: " + patient.LastName);
                Console.WriteLine("Phone No: " + patient.PhoneNo);
                Console.WriteLine("Gender: " + patient.Gender);
                Console.WriteLine("Age: " + patient.Age);
                Console.WriteLine("Address: " + patient.Address);
                Console.WriteLine("Aadhar No: " + patient.AadharNo);
                Console.WriteLine("Speciality: " + patient.Speciality);
                Console.WriteLine("------------------------");
            }
        }
        
         static void DisplaySpecificPatientDetails()
        {   
             Patient newPatient = new Patient();
             
            Console.WriteLine("Enter Aadhar No:");
            int n = int.Parse(Console.ReadLine());
            
            foreach (var patient in patients)
            {    
                if (patient.AadharNo == n)
                {
                             
                Console.WriteLine("Registration ID: " + patient.RegistrationID);
                Console.WriteLine("First Name: " + patient.FirstName);
                Console.WriteLine("Last Name: " + patient.LastName);
                Console.WriteLine("Phone No: " + patient.PhoneNo);
                Console.WriteLine("Gender: " + patient.Gender);
                Console.WriteLine("Age: " + patient.Age);
                Console.WriteLine("Address: " + patient.Address);
                Console.WriteLine("Aadhar No: " + patient.AadharNo);
                Console.WriteLine("Speciality: " + patient.Speciality);
                Console.WriteLine("------------------------");
                }
               
            }
        }

        static void RegisterNewPatient()
        {
            Patient newPatient = new Patient();
            
            Console.WriteLine("Enter Aadhar No:");
            newPatient.AadharNo = int.Parse(Console.ReadLine());

            if (IsDuplicatePatient(newPatient))
            {
                Console.WriteLine("A patient with the same Aadhar card already exists.");
                return;
            }

            Console.WriteLine("Enter First Name:");
            newPatient.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            newPatient.LastName = Console.ReadLine();

            Console.WriteLine("Enter Phone No:");
            newPatient.PhoneNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Gender:");
            newPatient.Gender = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            newPatient.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Address:");
            newPatient.Address = Console.ReadLine();

            
            Console.WriteLine("Enter Speciality to be consulted:");
            Console.WriteLine("i) General Medicine");
            Console.WriteLine("ii)Orthopaedics");
            Console.WriteLine("iii)Dental");
            
            newPatient.Speciality = Console.ReadLine();

            newPatient.RegistrationID = GenerateRegistrationID();
            patients.Add(newPatient);

            Console.WriteLine("Patient registered successfully. Registration ID: " + newPatient.RegistrationID);
        }

        static bool IsDuplicatePatient(Patient newPatient)
        {
            foreach (var patient in patients)
            {
                if (patient.AadharNo == newPatient.AadharNo)
                {
                    return true;
                }
            }
            return false;
        }

        static int GenerateRegistrationID()
        {
            int maxRegistrationID = 0;
            foreach (var patient in patients)
            {
                if (patient.RegistrationID > maxRegistrationID)
                {
                    maxRegistrationID = patient.RegistrationID;
                }
            }
            return maxRegistrationID + 1;
        }
    }
}
