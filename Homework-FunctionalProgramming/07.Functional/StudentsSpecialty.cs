﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.StudentsJoinedSpeciality
{
    class StudentSpecialty
    {
        public string SpecialtyName { get; set; }
        public string FacultyNumber { get; set; }


        public StudentSpecialty(string specialtyName, string facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;


        }
        public static void Main()
        {
            var studentsSpecialty = new List<StudentSpecialty>
               {
                   new StudentSpecialty("Web Developer","2255332"),
                   new StudentSpecialty("PHP Developer","3597415"),
                   new StudentSpecialty("Web Develope","8534697"),
                   new StudentSpecialty("PHP Developer","6324875"),
                   new StudentSpecialty("QA Engineer","5369554"),
                   new StudentSpecialty("QA Engineer","8546541")
                };
        }
    }
}
